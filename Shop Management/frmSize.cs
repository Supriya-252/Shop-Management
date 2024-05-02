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
    public partial class frmSize : Form
    {
        public frmSize()
        {
            InitializeComponent();
        }

        private void frmSize_Load(object sender, EventArgs e)
        {
            clsShopManagement objShowType = new clsShopManagement();
            DataTable dt = new DataTable();
            dt = objShowType.ShowType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in Controls)
            {

                if (control is TextBox)
                {

                    ((TextBox)control).Text = string.Empty;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).Text = string.Empty;
                }
            }
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            clsShopManagement objShowProductName = new clsShopManagement(TypeId);
            DataTable dt = new DataTable();
            dt = objShowProductName.ShowProductName();
            cmbbxProductName.DisplayMember = "ProductName";
            cmbbxProductName.ValueMember = "ProductId";
            cmbbxProductName.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            int ProductId = Convert.ToInt32(cmbbxProductName.SelectedValue.ToString());
            string Size = txtbxSize.Text;
            int Price = Convert.ToInt32(txtbxPrice.Text);
            clsShopManagement objFinalProductSave = new clsShopManagement(TypeId,ProductId,Size,Price);
            objFinalProductSave.FinalProductRegister();
            MessageBox.Show("Final Product Saved...");
        }

        private void cmbbxProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}