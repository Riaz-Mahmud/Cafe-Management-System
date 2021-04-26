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
    public partial class SignupForm : Form
    {
        DataAccess dataAccess;
        public SignupForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (nametxt.Text.Equals("") || usernameTxt.Text.Equals("") || passwordTxt.Text.Equals(""))
            {
                MessageBox.Show("Empty Fields");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "INSERT INTO user_info(userType,name,username,password) VALUES('2','" + nametxt.Text + "','" + usernameTxt.Text + "', '" + passwordTxt.Text + "')";
                int result = dataAccess.ExecuteQuery(sql);
                dataAccess.Dispose();
                if (result == 1)
                {
                    clearText();
                    MessageBox.Show("Account Created Successful");
                }
                else
                {
                    MessageBox.Show("Something going wring!");
                }
            }
        }

        public void clearText()
        {
            nametxt.Text = usernameTxt.Text = passwordTxt.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void SignupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
