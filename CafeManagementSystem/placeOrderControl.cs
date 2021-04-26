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
using DGVPrinterHelper;

namespace CafeManagementSystem
{
    public partial class placeOrderControl : UserControl
    {
        DataAccess dataAccess;
        String username;
        public placeOrderControl()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        public void setUsername(String uname)
        {
            this.username = uname;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCountUpDown.ResetText();
            ItemTotalTxt.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            itemNameTxt.Text = text;
            String sql = "select price from item where name = '" + text+"'";
            SqlDataAdapter daa = new SqlDataAdapter(sql, dataAccess.connection);
            DataSet ds = new DataSet();
            daa.Fill(ds);

            try
            {
                itemPriceTxt.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception) { }
            dataAccess.Dispose();

        }

        private void txtCountUpDown_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(txtCountUpDown.Value.ToString());
            Int64 price = Int64.Parse(itemPriceTxt.Text);
            ItemTotalTxt.Text = (quan * price).ToString();
        }

        private int n, total = 0;
        private void addCartBtn_Click(object sender, EventArgs e)
        {
            if(ItemTotalTxt.Text != "0" && ItemTotalTxt.Text != "")
            {
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = itemNameTxt.Text;
                dataGridView1.Rows[n].Cells[1].Value = itemPriceTxt.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtCountUpDown.Value;
                dataGridView1.Rows[n].Cells[3].Value = ItemTotalTxt.Text;

                total += int.Parse(ItemTotalTxt.Text);
                grandTotalTxt.Text = "Tk " + total;

                txtCountUpDown.ResetText();
                ItemTotalTxt.Clear();
                itemNameTxt.Clear();
                itemPriceTxt.Clear();
            }
            else
            {
                MessageBox.Show("Minimum Quantity need to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        int amount;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch (Exception)
            {
               
            }
        }

        private void removeCartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedCells[0].RowIndex);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error: "+ ex);
            }
            total -= amount;
            grandTotalTxt.Text = "Tk " + total;

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String Category = comboBox1.Text;
            String query = "Select * from item where category='" + Category + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, dataAccess.connection);
            DataSet ds = new DataSet();
            da.Fill(ds);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][1].ToString());
            }
            da.Dispose();
            ds.Dispose();
            dataAccess.Dispose();
        }

        private void placeOrder_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Customer Bill";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + grandTotalTxt.Text;
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dataGridView1);

        }

    }
}
