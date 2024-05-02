using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.AxHost;

namespace Shop_Management
{
    public partial class RegisterUser : Form
    {
        string Gender, State, Country;
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void RegisterUser_Load(object sender, EventArgs e)
        {

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
            rdbtnMale.Checked = false; rdbtnFemale.Checked = false;

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string Type = cmbbxType.SelectedItem.ToString(), Name = txtbxName.Text, Email = txtbxEmail.Text, PhoneNumber = txtbxPhoneNumber.Text, Country = cmbbxCountry.SelectedItem.ToString(), State = cmbbxState.SelectedItem.ToString(), City = cmbbxCity.SelectedItem.ToString(), Password = txtbxPassword.Text;
            if (rdbtnMale.Checked == true)
            {
                Gender = rdbtnMale.Text;
            }
            else
            {
                Gender = rdbtnFemale.Text;
            }
            if (rdbtnMale.Checked == false && rdbtnFemale.Checked == false)
            {
                lblGender.Show();
            }
            clsShopManagement objShopManagement = new clsShopManagement(Type,Name,Email,PhoneNumber,Gender,Country,State,City,Password);
            objShopManagement.Register();
;

        }

        private void rdbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbbxState_SelectedIndexChanged(object sender, EventArgs e)
        {
            State = cmbbxState.SelectedItem.ToString();
            cmbbxCity.Items.Clear();
            if (State == "Maharashtra")
            {
                cmbbxCity.Items.Add("Mumbai");
                cmbbxCity.Items.Add("Pune");
                cmbbxCity.Items.Add("Satara");

            }
            else if (State == "Gujarat")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Ahmedabad");
                cmbbxCity.Items.Add("Patan");
                cmbbxCity.Items.Add("Surat");

            }
            else if (State == "U.P")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Lucknow");
                cmbbxCity.Items.Add("Etah");
                cmbbxCity.Items.Add("Noida");
            }
            else if (State == "Hokkaido")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Sapporo");
                cmbbxCity.Items.Add("Hakodate");
                cmbbxCity.Items.Add("Abashiri");

            }
            else if (State == "Kyushu")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Fuckuoka");
                cmbbxCity.Items.Add("Beppu");
                cmbbxCity.Items.Add("Kagoshima");
            }
            else if (State == "Kansai")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Osaka");
                cmbbxCity.Items.Add("Kyoto");
                cmbbxCity.Items.Add("Nara");

            }
            else if (State == "California")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("L.A");
                cmbbxCity.Items.Add("Santa Monica");
                cmbbxCity.Items.Add("San Diego");
            }
            else if (State == "Texas")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Houston");
                cmbbxCity.Items.Add("Dallas");
                cmbbxCity.Items.Add("Austin");

            }
            else if (State == "Florida")
            {
                cmbbxCity.Items.Clear();
                cmbbxCity.Items.Add("Miami");
                cmbbxCity.Items.Add("Orlando");
                cmbbxCity.Items.Add("Tampa");
            }

        }

        private void cmbbxCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            Country = cmbbxCountry.SelectedItem.ToString();

            if (Country == "India")
            {
                cmbbxState.Items.Clear();
                cmbbxState.Items.Add("Maharashtra");
                cmbbxState.Items.Add("Gujarat");
                cmbbxState.Items.Add("U.P");
            }
            else if (Country == "Japan")
            {
                cmbbxState.Items.Clear();
                cmbbxState.Items.Add("Hokkaido");
                cmbbxState.Items.Add("Kyushu");
                cmbbxState.Items.Add("Kansai");

            }
            else if (Country == "USA")
            {
                cmbbxState.Items.Clear();
                cmbbxState.Items.Add("California");
                cmbbxState.Items.Add("Texas");
                cmbbxState.Items.Add("Florida");
            }
        }
    }
}





