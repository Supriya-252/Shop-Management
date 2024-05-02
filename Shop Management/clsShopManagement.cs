using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace Shop_Management
{
    internal class clsShopManagement
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-F06OJCFN\\SQLEXPRESS;Initial Catalog=ShopManagement;Integrated Security=True");
        //Register Page 1. User Form
        public string MyType { get; set; }
        public string MyName { get; set; }
        public string MyEmail { get; set; }
        public string MyPhoneNumber { get; set; }
        public string MyGender { get; set; }
        public string MyCountry { get; set; }
        public string MyState { get; set; }
        public string MyCity { get; set; }
        public string MyPassword { get; set; }
        public int UserId { get; set; }

        public int FinalProductId { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int OrderId { get; set; }
        public float Discount { get; set; }

        public clsShopManagement(int orderid, float discount)
        {
            OrderId = orderid;
            Discount = discount;
        }



        public clsShopManagement()
        {

        }
        public clsShopManagement(string type, string name, string email, string phonenumber, string gender, string country, string state, string city, string password)
        {
            MyType = type;
            MyName = name;
            MyEmail = email;
            MyPhoneNumber = phonenumber;
            MyGender = gender;
            MyCountry = country;
            MyState = state;
            MyCity = city;
            MyPassword = password;
        }
        public clsShopManagement(string name, string productname)
        {
            MyName = name;
            ProductName = productname;
        }

        public void Register()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "Register");
            cmd.Parameters.AddWithValue("@UserType", MyType);
            cmd.Parameters.AddWithValue("@UserName", MyName);
            cmd.Parameters.AddWithValue("@UserEmail", MyEmail);
            cmd.Parameters.AddWithValue("@UserPhoneNumber", MyPhoneNumber);
            cmd.Parameters.AddWithValue("@UserGender", MyGender);
            cmd.Parameters.AddWithValue("@UserCountry", MyCountry);
            cmd.Parameters.AddWithValue("@UserState", MyState);
            cmd.Parameters.AddWithValue("@UserCity", MyCity);
            cmd.Parameters.AddWithValue("@UserPassword", MyPassword);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public clsShopManagement(string type, string email, string password)
        {
            MyType = type;
            MyEmail = email;
            MyPassword = password;
        }

        public Tuple<int, string, string> LoginCheck(string type, string email, string password)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "LoginCheck");
            cmd.Parameters.AddWithValue("@UserType", MyType);
            cmd.Parameters.AddWithValue("@UserEmail", MyEmail);
            cmd.Parameters.AddWithValue("@UserPassword", MyPassword);
            cmd.Parameters.AddWithValue("@UserName", MyName);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                int UserId = int.Parse(dr["UserId"].ToString());
                string Name = dr["UserName"].ToString();
                string Email = dr["UserEmail"].ToString();

                return Tuple.Create(UserId, Name, Email);

            }
            return null;
           


        }

        //Product Page : 1. Type Form
        public string TypeName { get; set; }

        public clsShopManagement(string typename)
        {
            TypeName = typename;
        }

        public void SaveDataInType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveDataInType");
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Product Page : 2. Product Form 
        public int TypeId { get; set; }
        public string ProductName { get; set; }

        public clsShopManagement(int typeid, string productname)
        {
            TypeId = typeid;
            ProductName = productname;
        }
        public void SaveDataInProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveDataInProduct");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public DataTable ShowType()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowType");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }

        //Product Page 3. FinalProductRegister
        public int ProductId { get; set; }
        public string Size { get; set; }
        public int Price { get; set; }

        public clsShopManagement(int typeid)
        {
            TypeId = typeid;
        }
        public clsShopManagement(int typeid, int productid, string size, int price)
        {
            TypeId = typeid;
            ProductId = productid;
            Size = size;
            Price = price;
        }

        public DataTable ShowProductName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowProductname");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            return dt;
        }
        public void FinalProductRegister()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "FinalProductRegister");
            cmd.Parameters.AddWithValue("@TypeId", TypeId);
            cmd.Parameters.AddWithValue("@ProductId", ProductId);
            cmd.Parameters.AddWithValue("@Size", Size);
            cmd.Parameters.AddWithValue("@Price", Price);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Home Page
        public int ProductNameId { get; set; }
        public int ProductSizeId { get; set; }



        public DataTable ShowDataInGrid(int ProductNameId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowDataInGrid");
            cmd.Parameters.AddWithValue("@ProductNameId", ProductNameId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }
        public DataTable FetchProductPrice(int ProductSizeId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowPrice");
            cmd.Parameters.AddWithValue("@ProductSizeId", ProductSizeId);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;

        }

        //Order Page


        public clsShopManagement(int finalproductid, DateTime date, int userid)
        {

            FinalProductId = finalproductid;
            Date = date;
            UserId = userid;
        }
        public void SaveOrderDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SaveOrderDetails");
            cmd.Parameters.AddWithValue("@FinalProductId", FinalProductId);
            cmd.Parameters.AddWithValue("@Date", Date);
            cmd.Parameters.AddWithValue("@UserId", UserId);
            cmd.Parameters.AddWithValue("@Status", "Confirmed");
            cmd.Parameters.AddWithValue("@IsDeleted", "0");
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //Show Order Products Details
        public DataTable ShowAllProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowAllProducts");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ShowOrderProductsDetails()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowOrderProductsDetails");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SearchByName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchByName");
            cmd.Parameters.AddWithValue("@UserName", MyName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SearchByProduct()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchByProduct");
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable SearchByNameandProductName()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "SearchByNameandProductName");
            cmd.Parameters.AddWithValue("@UserName", MyName);
            cmd.Parameters.AddWithValue("@ProductName", ProductName);
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable ShowUnorderedProducts()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "ShowUnorderedProducts");
            SqlDataAdapter adpt = new SqlDataAdapter();
            adpt.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adpt.Fill(dt);
            con.Close();
            return dt;
        }
        public void UpdateDiscount()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "UpdateDiscount");
            cmd.Parameters.AddWithValue("@OrderId", OrderId);
            cmd.Parameters.AddWithValue("@Discount", Discount);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void IsDeleted(int OrderId)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("Register", con);
            cmd.CommandType= CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Flag", "IsDeleted");
            cmd.Parameters.AddWithValue("OrderId",OrderId); 
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}













        
