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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void orderProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrderProductsInformation obj = new frmOrderProductsInformation();
            obj.MdiParent = this;
            obj.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUnorderedProducts objUnorderedProducts = new frmUnorderedProducts();
            objUnorderedProducts.MdiParent = this; 
            objUnorderedProducts.Show();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAllProducts objAllProducts = new frmAllProducts();
            objAllProducts.MdiParent = this;
            objAllProducts.Show();
        }
    }
}
