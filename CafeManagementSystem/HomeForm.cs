using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class HomeForm : Form
    {
        String username;
        public HomeForm()
        {
            InitializeComponent();
        }
        public HomeForm(String username,int userType)
        {
            InitializeComponent();
            this.username = username;
            if (userType == 2)
            {
                addItemBtn.Visible = false;
                updateItemBtn.Visible = false;
                removeItembtn.Visible = false;
            }
            else if (userType==1)
            {
                addItemBtn.Visible = true;
                updateItemBtn.Visible = true;
                removeItembtn.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void placeOrderBtn_Click(object sender, EventArgs e)
        {
            placeOrderControl1.Visible = true;
            placeOrderControl1.BringToFront();
            placeOrderControl1.setUsername(username);
            placeOrderControl1.loadCategory();
        }

        private void addItemBtn_Click(object sender, EventArgs e)
        {
            addItemControl1.Visible = true;
            addItemControl1.BringToFront();
            addItemControl1.loadCategory();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            placeOrderControl1.Visible = true;
            placeOrderControl1.BringToFront();
            placeOrderControl1.setUsername(username);
            placeOrderControl1.loadCategory();
        }

        private void updateItemBtn_Click(object sender, EventArgs e)
        {
            itemUpdateControl1.Visible = true;
            itemUpdateControl1.BringToFront();
            itemUpdateControl1.loadItem();
            itemUpdateControl1.loadCategory();
        }

        private void removeItembtn_Click(object sender, EventArgs e)
        {
            itemDeleteControl1.Visible = true;
            itemDeleteControl1.BringToFront();
            itemDeleteControl1.loadItem();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            placeOrderControl1.Visible = true;
            placeOrderControl1.BringToFront();
            placeOrderControl1.setUsername(username);
            placeOrderControl1.loadCategory();
        }
    }
}
