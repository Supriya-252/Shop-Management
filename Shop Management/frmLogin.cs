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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        
        {
            string Type= cmbbxType.SelectedItem.ToString(),Email= txtbxEmail.Text,Password = txtbxPassword.Text;
            clsShopManagement objLogin = new clsShopManagement(Type,Email,Password);
            var UserDetails = (objLogin.LoginCheck(Type, Email, Password));
            if(Type =="Admin")
            {
                frmAdmin objAdmin = new frmAdmin();
                objAdmin.Show();
            }
            else
            {
                if(UserDetails != null)
                {
                    MessageBox.Show("Login Successful...");
                    frmHome objHome = new frmHome(UserDetails.Item1,UserDetails.Item2,UserDetails.Item3);
                    objHome.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials...");
                }
            }
           
     
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
