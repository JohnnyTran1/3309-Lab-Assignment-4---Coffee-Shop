using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class frmCustomerOrder : Form
    {
        //global 
        Customer customer;
        Food food;
        Order order;
        string sourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        List<Food> loadedItems = new List<Food>();
        Dictionary<Food, int> itemSelected = new Dictionary<Food, int>();
        ItemDB itemDB = new ItemDB();
        public frmCustomerOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            //load the items from the database to the data frid view
            dgvMenu.DataSource = itemDB.MenuDisplay();

            dgvSelectedItem.Columns.Add("ShortDescription", "Short Description");
            dgvSelectedItem.Columns.Add("Price", "Price");
            dgvSelectedItem.Columns.Add("Quantity", "Quantity");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //This is from the input invalid lecture slide
            //Cant let the user enter numbers, symbols and etcs, they need to put letters 
            //becauase names contains only letters
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNameEnter.Text, "^[a-zA-Z ]"))
            {
                lblError.Text = "Name only accept letters!";
                lblError.Visible = true;
                return;
            }

            //There is a link from the input invalid lecture slide to the mircsoft learn, this list regex and the types of input you can allows
            //@"^(\d{10}|)$" just validates if the input is a 10 digits number or is empty
            // Doesnt make sense to have a phone number that isnt 10 digits here and i dont want to force users to enter phone numbers
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtPhoneNumberEnter.Text, @"^(\d{10}|)$"))
            {
                lblError.Text = "Phone number must be a positive 10 digits number or left blank!";
                lblError.Visible = true;
                return;
            }

            string name = txtNameEnter.Text;
            string phone = txtPhoneNumberEnter.Text;
            string address = txtAddressEnter.Text;
            customer = new Customer(name, phone, address);

            //This  is a ternary operator, rather than do a if else statement; you can do a line one
            //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
            string deliveryMethod = radDelivery.Checked ? "Delivery" : "Pickup";
            //string deliveryMethod;
            //if (radDelivery.Checked)
            //{
            //    deliveryMethod = "Delivery";
            //}
            //else
            //{
            //  deliveryMethod = "Pickup";
            //}

            //A both condition that requires at least one of the radio button to be checked
            if (!radDelivery.Checked && !radPickUp.Checked)
            {
                lblError.Text = "Please select a type of order!";
                lblError.Visible = true;
                return;
            }

            //tip
            double tipValue = 0;
            //another regex from the input validation lecture slide
            //basically a tip isnt a requirement to enter but you do need to need a number becayse tip is optainal
            //a user can just enter letters and symbol, first it wouldnt make sense
            //second the tip is added to the total bill so it will prob cause a crash
            //also there are no such thing as negative numbers in tips, the shop owner dont owned customer money
            if (string.IsNullOrWhiteSpace(txtTip.Text))
            {
                tipValue = 0;  
            }
            else if (!double.TryParse(txtTip.Text, out tipValue) || tipValue < 0)
            {
                lblError.Text = "Tip must be a positive number!";
                lblError.Visible = true;
                return;
            }
            string tip = tipValue.ToString();

            int qty;
            //qty is just how many we want for the items we selected
            if (!int.TryParse(txtQty.Text, out qty) || qty <= 0)
            {
                lblError.Text = "Please enter a postive number for qty.";
                lblError.Visible = true;
                return;
            }

            // new order 
            order = new Order(customer, deliveryMethod, tip, qty, food, itemSelected);

            //Create an instance of the form to open and use
            frmCustomerReceipt customerReceiptForm = new frmCustomerReceipt(order);
            customerReceiptForm.ShowDialog();// modal form

        }

        //Event handler for my lvtMenu
        private void ltvMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvMenu.SelectedRows.Count == 0)
            {
                lblError.Text = "Please select an item from the menu!";
                lblError.Visible = true;
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQty.Text) || !int.TryParse(txtQty.Text, out int qty) || qty <= 0)
            {
                lblError.Text = "Please enter a valid positive quantity!";
                lblError.Visible = true;
                return;
            }

            string selectedItemName = dgvMenu.SelectedRows[0].Cells["ShortDescription"].Value.ToString();
            string selectedItemPrice = dgvMenu.SelectedRows[0].Cells["Price"].Value.ToString();
            
        }


        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void pbxImage_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNameEnter.Text = "";
            txtAddressEnter.Text = "";
            txtPhoneNumberEnter.Text = "";

            txtQty.Text = "";

            txtTip.Text = "";

            radDelivery.Checked = false;
            radPickUp.Checked = false;

        }

        //event handler for datagrod view (dgvMenu)
        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMenu.CurrentRow != null)
            {
                string shortDescription = dgvMenu.CurrentRow.Cells["ShortDescription"].Value.ToString();
                DataTable itemDetails = itemDB.GetItemDetails(shortDescription);
                //stackover - "How to delete a selected DataGridViewRow and update a connected database table?"
                //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
                //string longDescription = dgvMenu.CurrentRow.Cells["LongDescription"].Value.ToString();
                //string price = dgvMenu.CurrentRow.Cells["Price"].Value.ToString();
                //string cost = dgvMenu.CurrentRow.Cells["Cost"].Value.ToString();
                //string imageUrl = dgvMenu.CurrentRow.Cells["Image"].Value.ToString();

                //lblShortDescription.Text = shortDescription;
                //lblLongDescription.Text = longDescription;
                //lblPriceDisplay.Text = "$" + price;
                //lblCostDisplay.Text = "$" + cost;
                if (itemDetails.Rows.Count > 0)
                {
                    DataRow row = itemDetails.Rows[0];
                    lblLongDescription.Text = row["LongDescription"].ToString();
                    string imageUrl = row["Image"].ToString();
                    try
                    {
                        pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
                        pbxImage.Load(imageUrl);
                    }
                    catch
                    {
                        // Load a default image in case of an error
                        pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
                        pbxImage.Load("https://cdn.dribbble.com/users/1012566/screenshots/4187820/media/985748436085f06bb2bd63686ff491a5.jpg");

                    }
                }
            }
        }

        private void lblLongDescription_Click(object sender, EventArgs e)
        {

        }
    }
}
