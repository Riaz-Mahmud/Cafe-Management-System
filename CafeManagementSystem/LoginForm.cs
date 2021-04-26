using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagementSystem
{
    public partial class LoginForm : Form
    {
        DataAccess dataAccess;
        public LoginForm()
        {
            InitializeComponent();
            dataAccess = new DataAccess();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(UsernameText.Text.Equals("") || passwordText.Text.Equals(""))
            {
                MessageBox.Show("Empty Field");
            }
            else
            {
                dataAccess = new DataAccess();
                string sql = "SELECT * FROM user_info WHERE username='" + UsernameText.Text + "' AND password='" + passwordText.Text + "' AND status=1";
                SqlDataReader reader = dataAccess.GetData(sql);
                reader.Read();
                try
                {
                    int isAvailabe = (int)reader["userType"];
                    if (isAvailabe == 1)
                    {
                        String uname = UsernameText.Text;
                        UsernameText.Text = "";
                        passwordText.Text = "";
                        
                        HomeForm homeFrom = new HomeForm(uname,1);
                        homeFrom.Show();
                        this.Hide();

                    }
                    else if (isAvailabe == 2)
                    {
                        String uname = UsernameText.Text;
                        UsernameText.Text = "";
                        passwordText.Text = "";
                        
                        HomeForm homeFrom = new HomeForm(uname,2);
                        homeFrom.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Login Failed");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Login Failed!");
                }
                dataAccess.Dispose();
            }
        }

        private void createNewAccount_Click(object sender, EventArgs e)
        {
            SignupForm signUpForm = new SignupForm();
            signUpForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
