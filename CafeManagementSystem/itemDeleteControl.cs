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
    public partial class itemDeleteControl : UserControl
    {
        DataAccess dataAccess;
        public itemDeleteControl()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
            loadItem();
        }

        public void loadItem()
        {

            DataTable dataTable = new DataTable();
            string sql = "Select * from item ";
            SqlDataAdapter sda = new SqlDataAdapter(sql, dataAccess.connection);
            sda.Fill(dataTable);
            DeleteDataGridView.DataSource = dataTable;
            dataAccess.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (itemId.Equals(""))
            {
                MessageBox.Show("Select First");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "Delete from item where id = '" + itemId + "'";
                int result = dataAccess.ExecuteQuery(sql);
                dataAccess.Dispose();
                if (result > 0)
                {
                    loadItem();
                    MessageBox.Show("Data deleted!");
                }
                else
                {
                    MessageBox.Show("ID Not found");
                }
            }
            
        }

        String itemId = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = DeleteDataGridView.Rows[rowIndex];
                itemId = row.Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                itemId = "";
            }
            
        }

        private void itemDeleteControl_Click(object sender, EventArgs e)
        {
            itemId = "";
        }

        private void itemDeleteControl_Load(object sender, EventArgs e)
        {
            loadItem();
        }

    }
}
