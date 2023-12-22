using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_CommerceSystem
{
    public partial class ProductDescription : KryptonForm
    {
        Config dbConfig;
        MySqlConnection conn;

        UserPrompt refreshForm;

        int cartCount; //global variable for cart count

        public ProductDescription()
        {
            InitializeComponent();
            this.FormClosing += ProductDescriptiom_FormClosing;

        }

        public ProductDescription(string product_id, string user_id, string product_name)
        {
            InitializeComponent();
            this.ProductID = product_id;
            this.UserID = user_id;
            this.PrdName = product_name;
            this.FormClosing += ProductDescriptiom_FormClosing;

        }

        public string ProductID { get; set; }
        public string UserID { get; set; }

        public string PrdName { get; set; }
        private void ProductDescription_Load(object sender, EventArgs e)
        {
            dbConfig = new Config();
            conn = dbConfig.getConnection();
            lbl_ref.Visible = false;
            add_to_cart.Enabled= false;

            MySqlCommand getUserPic = new MySqlCommand("SELECT picture_directory FROM users WHERE userID = ('" + UserID + "')", conn);
            MySqlCommand selectProductBasedOnID = new MySqlCommand("SELECT image, description, price, product_name, category FROM products WHERE productID = ('" + ProductID + "')", conn);

            try
            {
                conn.Open();

                MySqlDataReader fethcCurrentUserPic = getUserPic.ExecuteReader();
                fethcCurrentUserPic.Read();


                //display the image based on the fetched id
                long length = fethcCurrentUserPic.GetBytes(0, 0, null, 0, 0);
                byte[] arrays = new byte[System.Convert.ToInt32(length + 1)];
                fethcCurrentUserPic.GetBytes(0, 0, arrays, 0, System.Convert.ToInt32(length));

                MemoryStream picMemoryStream = new MemoryStream(arrays);
                Bitmap userPic = new Bitmap(picMemoryStream);

                //fetch the value of the default cart count from the database

                fethcCurrentUserPic.Close();

                //----------------------------------------------------------------------------
                MySqlDataReader fetchProductByID = selectProductBasedOnID.ExecuteReader();
                fetchProductByID.Read();

                if (fetchProductByID.GetString("category").Contains("Men Perfume"))
                {
                    string[] scents = {"SEXY MEN", "WILD MEN", "DREAM MEN"};

                    foreach(string scent in scents)
                    {
                        cmb_scent.Items.Add(scent);
                    }

                }
                else if (fetchProductByID.GetString("category").Contains("Women Perfume"))
                {

                    string[] scents = { "MAPLE RED", "STRAW HAT", "RUBY RUSH" };

                    foreach (string scent in scents)
                    {
                        cmb_scent.Items.Add(scent);
                    }

                }
                else
                {
                    string[] scents = { "PARTY", "SMELLY", "DREAMS" };

                    foreach (string scent in scents)
                    {
                        cmb_scent.Items.Add(scent);
                    }
                }

                //display the image based on the fetched id
                long productLength = fetchProductByID.GetBytes(0, 0, null, 0, 0);
                byte[] prodArray = new byte[System.Convert.ToInt32(productLength + 1)];
                fetchProductByID.GetBytes(0, 0, prodArray, 0, System.Convert.ToInt32(productLength));

                MemoryStream productMemoryStream = new MemoryStream(prodArray);
                Bitmap productPictures = new Bitmap(productMemoryStream);
                productPicture.Image = productPictures;

                //changed the desc, price, prdName according to the fetched id using the passed in value during this session
                ProductDesc.Text = fetchProductByID.GetString("description");
                ProductName.Text = fetchProductByID.GetString("product_name");
                ProductPrice.Text = $"₱{fetchProductByID.GetString("price")}";
                fetchProductByID.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void ProductDescriptiom_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshForm = new UserPrompt(UserID);
            refreshForm.UserPrompt_Load(sender, e);
        }

        private void ProductDescriptiom_FormClosing(object sender, FormClosingEventArgs e)
        {
            refreshForm = new UserPrompt(UserID);
            refreshForm.UserPrompt_Load(sender, e);

        }
 
        private void add_to_cart_Click(object sender, EventArgs e)
        {
            cartCount++;

            dbConfig = new Config();
            conn = dbConfig.getConnection();

            string productName, unitPrice;

            MySqlCommand fetchProductInfo = new MySqlCommand("SELECT image, product_name, price FROM products WHERE productID = ('" + ProductID + "') ", conn);

            try
            {
                conn.Open();
                MySqlDataReader fetchResult = fetchProductInfo.ExecuteReader();
                fetchResult.Read();

                productName = fetchResult.GetString("product_name");
                unitPrice = fetchResult.GetString("price");
                fetchResult.Close();

                MemoryStream ms = new MemoryStream();
                productPicture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arrImage = ms.GetBuffer();

                MySqlCommand checkIfProductExists = new MySqlCommand("SELECT * FROM cart WHERE productName = ('" + PrdName + "') AND userID = ('"+UserID+"')", conn);

                try
                {
                    MySqlDataReader fetchProductFromCart = checkIfProductExists.ExecuteReader();

                    fetchProductFromCart.Read();

                    if (fetchProductFromCart.HasRows)
                    {

                        int fetchUnitPrice = fetchProductFromCart.GetInt32("unitPrice");
                        int fetchTotalPrice = fetchProductFromCart.GetInt32("totalPrice");
                        fetchProductFromCart.Close();

                        int updateTotalPriceDupliPrdAdded = fetchTotalPrice + fetchUnitPrice;

                        MySqlCommand updateQuantity = new MySqlCommand("UPDATE cart SET productQuantity = productQuantity + 1, totalPrice = ('" + updateTotalPriceDupliPrdAdded + "'), variant = ('"+cmb_scent.Text+"') WHERE productName = ('" + PrdName + "')", conn);
                        updateQuantity.ExecuteNonQuery();

                        MessageBox.Show("ADDED TO CART");

                        ProductDescription_Load(sender, e);

                        this.Close();

                    }
                    else
                    {
                        fetchProductFromCart.Close();
                        MySqlCommand insertCart = new MySqlCommand("INSERT INTO cart (productName, variant ,unitPrice, productQuantity,totalPrice ,picture_directory,productID ,userID) VALUES (@productName,@variant ,@unitPrice, @productQuantity,@totalPrice ,@picture_directory,@productID, @userID) ", conn);

                        insertCart.Parameters.AddWithValue("@productName", productName);
                        insertCart.Parameters.AddWithValue("@variant", lbl_ref.Text);
                        insertCart.Parameters.AddWithValue("@unitPrice", unitPrice);
                        insertCart.Parameters.AddWithValue("@productQuantity", "1");
                        insertCart.Parameters.AddWithValue("@totalPrice", unitPrice);
                        insertCart.Parameters.AddWithValue("@picture_directory", arrImage);
                        insertCart.Parameters.AddWithValue("@productID", ProductID);
                        insertCart.Parameters.AddWithValue("@userID", UserID);

                        insertCart.ExecuteNonQuery();


                        MessageBox.Show("ADDED TO CART");

                        ProductDescription_Load(sender, e);

                        this.Close();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmb_scent_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_ref.Text = cmb_scent.Text;
            add_to_cart.Enabled= true;
        }
    }
}
