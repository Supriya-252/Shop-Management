using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class frmAllProducts : Form
    {
        public frmAllProducts()
        {
            InitializeComponent();
        }

        private void frmAllProducts_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsShopManagement objShowAllProducts = new clsShopManagement();
            dt = objShowAllProducts.ShowAllProducts();
            dgvShowAllProducts.DataSource = dt;
            dgvShowAllProducts.Show();
        }
    }
}







