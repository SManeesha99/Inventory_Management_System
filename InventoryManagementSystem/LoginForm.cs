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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
        }

        private void login_cb_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_cb.Checked ? '\0' : '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {

                    try
                    {
                        connect.Open();
                        String selectData = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password AND status = @status";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", login_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            int rowCount = (int)cmd.ExecuteScalar();


                            if(rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM users WHERE username = @username AND password = @password";

                                using(SqlCommand getRole = new SqlCommand(selectRole, connect))
                                {
                                    getRole.Parameters.AddWithValue("@username", login_username.Text.Trim());
                                    getRole.Parameters.AddWithValue("@password", login_password.Text.Trim());

                                    string userRole = getRole.ExecuteScalar() as string;
                                    MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    if(userRole == "Admin")
                                    {
                                        MainForm mainForm = new MainForm();
                                        mainForm.Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        CashierMainForm mainForm = new CashierMainForm();
                                        mainForm.Show();
                                        this.Hide();
                                    }
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password or there's no Admin's approval", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error database connecting " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

