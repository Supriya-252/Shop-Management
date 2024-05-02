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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string TypeName = txtbxType.Text;
            clsShopManagement objSaveDataInType = new clsShopManagement(TypeName);
            objSaveDataInType.SaveDataInType();


        }

        private void frmType_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbxType.Clear();
        }

        private void txtbxType_TextChanged(object sender, EventArgs e)
        {

        }
    }
}




