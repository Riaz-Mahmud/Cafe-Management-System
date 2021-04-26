using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CafeManagementSystem
{
    public partial class itemUpdateControl : UserControl
    {
        DataAccess dataAccess;
        public itemUpdateControl()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            loadItem();
        }

        private void itemUpdateControl_Load(object sender, EventArgs e)
        {
            loadItem();
            loadCategory();
        }

        public void loadCategory()
        {
            dataAccess = new DataAccess();
            string sql = "SELECT * FROM item_category";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<string> list = new List<string>();
            //list.Add("Select Sub-Category");
            while (reader.Read())
            {
                list.Add(reader["name"].ToString());
            }
            comboBox1.DataSource = list;
            dataAccess.Dispose();
        }
        public void loadItem()
        {

            DataTable dataTable = new DataTable();
            string sql = "Select * from item ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, dataAccess.connection);
            sda.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataAccess.Dispose();

        }

        String itemId = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            itemId = row.Cells[0].Value.ToString();
            itemNameTxt.Text = row.Cells[1].Value.ToString();
            comboBox1.SelectedItem = row.Cells[2].Value.ToString();
            itemPriceTxt.Text = row.Cells[3].Value.ToString();
        }

        private void itemUpdateControl_Click(object sender, EventArgs e)
        {
            itemId = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (itemNameTxt.Text.Equals("") || comboBox1.SelectedIndex == -1 || itemPriceTxt.Text.Equals(""))
            {
                MessageBox.Show("Empty");
            }
            else
            {
                try
                {
                    dataAccess = new DataAccess();
                    string sql = "UPDATE item SET category='" + comboBox1.SelectedItem.ToString() + "', name='" + itemNameTxt.Text + "',price='" + itemPriceTxt.Text + "' Where id ='" + itemId + "'";
                    SqlCommand commandImage = new SqlCommand(sql, dataAccess.connection);

                    int result = commandImage.ExecuteNonQuery();
                    dataAccess.Dispose();
                    if (result == 1)
                    {
                        MessageBox.Show("Update successfully.");
                        itemNameTxt.Text = itemPriceTxt.Text = "";
                        comboBox1.Text = "Select Category";
                        loadItem();
                    }
                    else
                    {
                        MessageBox.Show("Error occured..");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occured.." + ex);
                }
            }
        }
    }
}
