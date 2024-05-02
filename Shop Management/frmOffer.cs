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
    public partial class frmOffer : Form
    {
        public decimal RealPrice { get; set; }
        public int Price;
        public int OrderId { get; set; }
        public frmOffer()
        {
            InitializeComponent();
        }
        public frmOffer(string username,string productname,int price,int orderid)
        {
            InitializeComponent();
            lblUserName.Text = username;
            lblPrice.Text = price.ToString();
            lblProductName.Text = productname;
            OrderId = orderid;
            Price = price;
        }
        
        private void frmOffer_Load(object sender, EventArgs e)
        {


        }

        private void txtbxDiscountInPercentage_TextChanged(object sender, EventArgs e)
        {
            decimal DiscountInPercentage = Convert.ToDecimal(txtbxDiscountInPercentage.Text.ToString());
            decimal DiscountAmount = (Price * DiscountInPercentage / 100);
            decimal DiscountedPrice = Price - DiscountAmount;
            txtbxNewPrice.Text = DiscountedPrice.ToString();
            RealPrice = DiscountedPrice;
        }

        private void btnUpdatedPrice_Click(object sender, EventArgs e)
        {
            float Discount = float.Parse(txtbxDiscountInPercentage.Text);
            clsShopManagement objUpdate = new clsShopManagement(OrderId, Discount);
            objUpdate.UpdateDiscount();
            MessageBox.Show("Updated price added");
              
        }
    }

}
