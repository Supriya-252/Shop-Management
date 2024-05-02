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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int TypeId = Convert.ToInt32(cmbbxType.SelectedValue.ToString());
            string ProductName = txtbxProductName.Text;
            clsShopManagement objSaveDataInProduct = new clsShopManagement(TypeId, ProductName);
            objSaveDataInProduct.SaveDataInProduct();
            MessageBox.Show("Product name saved....");
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            clsShopManagement objShowType = new clsShopManagement();
            DataTable dt = new DataTable();
            dt = objShowType.ShowType();
            cmbbxType.DisplayMember = "TypeName";
            cmbbxType.ValueMember = "TypeId";
            cmbbxType.DataSource = dt;
        }

        private void cmbbxType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}





