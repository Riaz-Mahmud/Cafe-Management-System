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
    public partial class addItemControl : UserControl
    {
        DataAccess dataAccess;
        public addItemControl()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(itemNameTxt.Text.Equals("") || comboBox1.SelectedIndex == -1 || itemPriceTxt.Text.Equals(""))
            {
                MessageBox.Show("Empty");
            }
            else
            {
                try
                {
                    dataAccess = new DataAccess();
                    string sql = "INSERT INTO item(name,category,price) " +
                        "VALUES('" + itemNameTxt.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + itemPriceTxt.Text + "')";
                    SqlCommand commandImage = new SqlCommand(sql, dataAccess.connection);
                    int result = commandImage.ExecuteNonQuery();
                    dataAccess.Dispose();
                    if (result == 1)
                    {
                        MessageBox.Show("New Item add successfully.");
                        itemNameTxt.Text = itemPriceTxt.Text = "";
                        comboBox1.Text = "Select Category";
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
