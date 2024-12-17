using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementSystem
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Maniya\Documents\inventory.mdf;Integrated Security=True;Connect Timeout=30");
        public AdminAddProducts()
        {
            InitializeComponent();
            displayProductsData();
        }

        public bool emptyFeilds()
        {
            if (pro_id.Text == "" || pro_name.Text == "" || pro_price.Text == "" || pro_stock.Text == "" || pro_cat.Text == "" || pro_status.Text == "" || proImg.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayProductsData()
        {
            ProductsData uData = new ProductsData();

            List<ProductsData> listData = uData.AllProductData();

            proDataGridView.DataSource = listData;
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

                                string relativePath = Path.Combine("ProductsDirectory", pro_id.Text.Trim() + ".jpg");
                                string path = Path.Combine(baseDirectory, relativePath);

                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(proImg.ImageLocation, path, true);

                                string inserQuery = "INSERT INTO products (prod_id,prod_name,prod_price,prod_stock,image_path,categoryID,prod_status,date) " +
                                    "VALUES (@proID,@proName,@proPrice,@proStock,@imgPath,@catogery,@proStatus,@date)";

                                using (SqlCommand insertD = new SqlCommand(inserQuery, connect))
                                {
                                    insertD.Parameters.AddWithValue("@proID", pro_id.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proName", pro_name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proPrice", pro_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@proStock", pro_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@imgPath", path);
                                    insertD.Parameters.AddWithValue("@catogery", Convert.ToInt32(pro_cat.SelectedValue));
                                    insertD.Parameters.AddWithValue("@proStatus", pro_status.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    MessageBox.Show("Added Succesfully!", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    clearFields();
                                    displayProductsData();
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
            pro_stock.Text = "";
            pro_price.Text = "";
            pro_status.SelectedIndex = -1;
            pro_cat.SelectedIndex = -1;
            proImg.Image = null;
            imagePath = "";
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

        private void LoadCategories()
        {
            string query = "SELECT id, category FROM categories";

            using (SqlCommand cmd = new SqlCommand(query, connect))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                pro_cat.DataSource = table;
                pro_cat.DisplayMember = "category";
                pro_cat.ValueMember = "id";
            }
        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {
            LoadCategories();
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

        private int getID = 0;
        private String imagePath;
        private void proDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = proDataGridView.Rows[e.RowIndex];
                getID = (int)row.Cells[0].Value;
                pro_id.Text = row.Cells[1].Value.ToString();
                pro_name.Text = row.Cells[2].Value.ToString();
                pro_cat.Text = row.Cells[3].Value.ToString();
                pro_price.Text = row.Cells[4].Value.ToString();
                pro_stock.Text = row.Cells[5].Value.ToString();

                imagePath = row.Cells[6].Value.ToString();
                string imageData = row.Cells[6].Value.ToString();
                if (imageData != null && imageData.Length > 0)
                {
                    proImg.Image = Image.FromFile(imageData);
                }
                else
                {
                    proImg.Image = null;
                }


                pro_status.Text = row.Cells[7].Value.ToString();

            }
        }

        private void proUpdateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFeilds())
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update product ID " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                            string updateQuery = "UPDATE products SET prod_name = @proName, prod_price = @proPrice, prod_stock = @proStock, " +
                     "image_path = @imgPath, categoryID = @catogery, prod_status = @proStatus " +
                     "WHERE prod_id = @proID";

                            using (SqlCommand updateD = new SqlCommand(updateQuery, connect))
                            {
                                updateD.Parameters.AddWithValue("@proID", pro_id.Text.Trim());
                                updateD.Parameters.AddWithValue("@proName", pro_name.Text.Trim());
                                updateD.Parameters.AddWithValue("@proPrice", pro_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@proStock", pro_stock.Text.Trim());

                                // File Handling
                                string relativePath = Path.Combine("ProductsDirectory", pro_id.Text.Trim() + ".jpg");
                                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, relativePath);

                                if (!Directory.Exists(Path.GetDirectoryName(path)))
                                    Directory.CreateDirectory(Path.GetDirectoryName(path));

                                if (!string.IsNullOrEmpty(proImg.ImageLocation))
                                {
                                    if (File.Exists(path))
                                        File.Delete(path);

                                    File.Copy(proImg.ImageLocation, path, true);
                                }
                                else
                                {
                                    MessageBox.Show("No image selected. Please select an image before updating.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                updateD.Parameters.AddWithValue("@imgPath", path);
                                updateD.Parameters.AddWithValue("@catogery", Convert.ToInt32(pro_cat.SelectedValue));
                                updateD.Parameters.AddWithValue("@proStatus", pro_status.Text.Trim());

                                updateD.ExecuteNonQuery();
                                MessageBox.Show("Update Successfully!", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                clearFields();
                                displayProductsData();
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
        }

        private void proClearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void proRemoveBtn_Click(object sender, EventArgs e)
        {
            if (pro_id.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete product ID " + getID + " ? ", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();
                            string deleteQuery = "DELETE FROM products WHERE id = @id";

                            using (SqlCommand deleteD = new SqlCommand(deleteQuery, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                displayProductsData();
                                MessageBox.Show("Products Delete Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
