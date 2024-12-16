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
    public partial class AdminCategoriesManage : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");


        public AdminCategoriesManage()
        {
            InitializeComponent();
            displayCategoriesData();
        }

        public void displayCategoriesData()
        {
            CategoriesData catData = new CategoriesData();

            List<CategoriesData> listData = catData.AllCategoriesData();

            catDataGridView.DataSource = listData;
        }

        private void catAddBtn_Click(object sender, EventArgs e)
        {
            if (category.Text == "")
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
                        string checkExistCategory = "SELECT * FROM categories WHERE category = @category";

                        using (SqlCommand cmd = new SqlCommand(checkExistCategory, connect))
                        {
                            cmd.Parameters.AddWithValue("@category", category.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(category.Text.Trim() + "is already exists", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string inserQuery = "INSERT INTO categories (category, date) VALUES (@category, @date)";
                                using (SqlCommand insertD = new SqlCommand(inserQuery, connect))
                                {
                                    insertD.Parameters.AddWithValue("@category", category.Text.Trim());

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today.ToString());

                                    insertD.ExecuteNonQuery();
                                    displayCategoriesData();
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
            category.Text = "";

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

        private void catClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void catUpdateBtn_Click(object sender, EventArgs e)
        {
            if (category.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this category id " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string updateQuery = "UPDATE categories SET category = @category WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateQuery, connect))
                            {
                                updateD.Parameters.AddWithValue("@category", category.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayCategoriesData();
                                MessageBox.Show("Categories Records Updated Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void catDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = catDataGridView.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                category.Text = row.Cells[1].Value.ToString();
            }
        }

        private void catRemoveBtn_Click(object sender, EventArgs e)
        {
            if (category.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this category id " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string deleteQuery = "DELETE FROM categories WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(deleteQuery, connect))
                            {
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                displayCategoriesData();
                                MessageBox.Show("Categories Records Remove Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
