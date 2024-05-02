using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Management
{
    public partial class frmUnorderedProducts : Form
    {
        public frmUnorderedProducts()
        {
            InitializeComponent();
        }

        private void frmUnorderedProducts_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsShopManagement objUnorderedProducts = new clsShopManagement();
            dt = objUnorderedProducts.ShowUnorderedProducts();
            dgvShowUnorderedProducts.DataSource = dt;
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn()
            {
                HeaderText = "Select Column",
                Name = "Select Column",
                DataPropertyName = "Select Column"

            };
            dgvShowUnorderedProducts.Columns.Insert(0, checkBoxColumn);
        }
    }
}




