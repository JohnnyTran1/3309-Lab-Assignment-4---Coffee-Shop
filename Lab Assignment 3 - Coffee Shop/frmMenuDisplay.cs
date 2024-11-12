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
//problem 
// need to create more filters
//my combo box cobCategory will filter the list view but makes our selectitem in the listview unusable because we can select anything anymore there our picturebox, short description, long description are worthless


namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class frmMenuDisplay : Form
    {
        string sourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        List<Food> displayMenu = new List<Food>();
        ItemDB itemDB = new ItemDB();
        public frmMenuDisplay()
        {
            InitializeComponent();
        }

        private void ltvMenuDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //pre load 
        private void frmMenuDisplay_Load(object sender, EventArgs e)
        {
            //load the items from the database to the data frid view
            dgvMenu.DataSource = itemDB.MenuDisplay();

            //autommatic populate the combox box selection
            cboSearchCategory.DataSource = itemDB.LoadCategoryTable();
            cboSearchCategory.DisplayMember = "Category";
            cboSearchCategory.ValueMember = "Category";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmCustomerOrder customerOrderForm = new frmCustomerOrder();
            customerOrderForm.ShowDialog();
        }

        private void lblLongDescription_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        //filters the list view to display only items of the selected category
        private void FilterListView()
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
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
                    lblCostDisplay.Text = "$" + row["Cost"].ToString();
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvMenu.DataSource = itemDB.MenuDisplay();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectCateogry = cboSearchCategory.SelectedValue.ToString();
            dgvMenu.DataSource = itemDB.LoadOnlySearchCategoryTableDisplayMenu(selectCateogry);
        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}