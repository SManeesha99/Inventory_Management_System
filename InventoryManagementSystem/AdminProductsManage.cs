﻿using System;
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
    public partial class AdminProductsManage : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminProductsManage()
        {
            InitializeComponent();
            displayProductsData();
        }

        public void displayProductsData()
        {
            ProductsData uData = new ProductsData();

            List<ProductsData> listData = uData.AllProductData();

            proDataGridView.DataSource = listData;
        }

        public bool emptyFeilds()
        {
            if (pro_id.Text == "" || pro_name.Text == "" || pro_cat.Text == "" || pro_price.Text == "" || pro_stock.Text == "" || pro_status.Text == "" || proImg.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void proAddBtn_Click(object sender, EventArgs e)
        {

            if (emptyFeilds())
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
                        string checkProId = "SELECT * FROM products WHERE prod_id = @proID";

                        using (SqlCommand cmd = new SqlCommand(checkProId, connect))
                        {
                            cmd.Parameters.AddWithValue("@proID", pro_id.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(pro_id.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                                string relativePath = Path.Combine("Product_Directory", pro_id.Text.Trim() + ".jpg");
                                string path = Path.Combine(baseDirectory, relativePath);

                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(proImg.ImageLocation, path, true);


                                string inserQuery = "INSERT INTO products (prod_id, prod_name, prod_price, prod_stock, image_path, prod_status, categoryID, date) " +
                                    "VALUES (@proID, @proName, @proPrice, @proStock, @imgPath, @catogery, @proStatus, @date)";

                                using (SqlCommand insertD = new SqlCommand(inserQuery, connect))
                                {
                                    insertD.Parameters.AddWithValue("@proID", pro_id.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proName", pro_name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proPrice", pro_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proStock", pro_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@imgPath", path);
                                    insertD.Parameters.AddWithValue("@catogery", Convert.ToInt32(pro_cat.SelectedValue));
                                    //insertD.Parameters.AddWithValue("@proStatus", pro_status.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proStatus", pro_status.SelectedItem.ToString().Trim());


                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Added Succesfully!", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();

                                }

                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error database connecting " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

        }

        private void clearFields()
        {
            pro_id.Text = "";
            pro_name.Text = "";
            pro_cat.SelectedIndex = -1;
            pro_status.SelectedIndex = -1;
            pro_stock.Text = "";
            pro_price.Text = "";
            proImg.Image = null;

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

        private void proClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void proImgUploadBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg, *png) | *.jpg;*.png";
                string imagePath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    proImg.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        

        private void AdminProductsManage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
