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

namespace InventoryManagementSystem
{
    public partial class UserManage : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");


        public UserManage()
        {
            InitializeComponent();
            displayUsersData();
        }

        public void displayUsersData()
        {
            UsersData uData = new UsersData();

            List<UsersData> listData = uData.AllUsersData();

            dataGridView1.DataSource = listData;
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            if (user_username.Text == "" || user_password.Text == "" || user_role.Text == "" || user_status.Text == "")
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
                        string checkUserName = "SELECT * FROM users WHERE username = @username";

                        using (SqlCommand cmd = new SqlCommand(checkUserName, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", user_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(user_username.Text.Trim() + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string inserQuery = "INSERT INTO users (username,password,role,status,date) VALUES (@username, @password, @role, @status, @date)";
                                using (SqlCommand insertD = new SqlCommand(inserQuery, connect))
                                {
                                    insertD.Parameters.AddWithValue("@username", user_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password", user_password.Text.Trim());
                                    insertD.Parameters.AddWithValue("@role", user_role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@status", user_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today.ToString());

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Added Succesfully!", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                }
                            }

                        }

                    }
                    catch (Exception ex)
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

        public void clearFields()
        {
            user_username.Text = "";
            user_password.Text = "";
            user_role.SelectedIndex = -1;
            user_status.SelectedIndex = -1;

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

        private void userClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void userUpdateBtn_Click(object sender, EventArgs e)
        {
            if (user_username.Text == "" || user_password.Text == "" || user_role.Text == "" || user_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update user ID " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string updateQuery = "UPDATE users SET username=@username , password = @password , role = @role , status = @status  WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateQuery, connect))
                            {
                                updateD.Parameters.AddWithValue("@username", user_username.Text.Trim());
                                updateD.Parameters.AddWithValue("@password", user_password.Text.Trim());
                                updateD.Parameters.AddWithValue("@role", user_role.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", user_status.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayUsersData();
                                MessageBox.Show("User Records Updated Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }

                        }
                        catch (Exception ex)
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
        }
        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                user_username.Text = row.Cells[1].Value.ToString();
                user_password.Text = row.Cells[2].Value.ToString();
                user_role.Text = row.Cells[3].Value.ToString();
                user_status.Text = row.Cells[4].Value.ToString();
            }
        }

        private void userRemoveBtn_Click(object sender, EventArgs e)
        {
            if (user_username.Text == "" || user_password.Text == "" || user_role.Text == "" || user_status.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete user ID " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string deleteQuery = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(deleteQuery, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayUsersData();
                                MessageBox.Show("User Records Delete Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                            }

                        }
                        catch (Exception ex)
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
        }
    }
}
