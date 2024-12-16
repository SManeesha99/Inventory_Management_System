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

        private void proAddBtn_Click(object sender, EventArgs e)
        {



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
