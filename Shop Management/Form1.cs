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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUser objRUser = new RegisterUser();
            objRUser.Show();
            objRUser.MdiParent = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType objType = new frmType();
            objType.MdiParent = this;
            objType.Show();
            
        }

        private void sizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct objProduct = new frmProduct();
            objProduct.MdiParent = this;
            objProduct.Show();
            
        }

        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSize objSize = new frmSize();
            objSize.MdiParent = this;
            objSize.Show();
            
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            objLogin.MdiParent= this;
            objLogin.Show();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
