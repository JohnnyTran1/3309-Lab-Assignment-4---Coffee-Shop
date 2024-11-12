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
// when create new items over time, it will create duplicates
namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class frmEmployeeCreate : Form
    {
        //internal the Food class and list to give access to the other forms
        //global
        internal Food food;
        //new list that contains all items
        List<Food> menu = new List<Food>();
        ItemDB itemDB = new ItemDB();
        //string sourceDir = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName;
        public frmEmployeeCreate()
        {
            InitializeComponent();
            
        }

        private void EmployeeCreate_Load(object sednder, EventArgs e)
        {
            //populate the combo box
            cobCategories.Items.Add(foodCategory.coffee);
            cobCategories.Items.Add(foodCategory.others);
            cobCategories.Items.Add(foodCategory.pastry);
            cobCategories.Items.Add(foodCategory.seasonal);
            cobCategories.Items.Add(foodCategory.smoothies);
            cobCategories.Items.Add(foodCategory.snacks);
            cobCategories.Items.Add(foodCategory.tea);

            //populate the existing records
            dgvMenu.DataSource = itemDB.LoadItemTable();
            //dgvMenu.Columns["ID"].Visible = false; 

            //populate the moditify combo box
            cobModifyCategory.Items.Add(foodCategory.coffee);
            cobModifyCategory.Items.Add(foodCategory.others);
            cobModifyCategory.Items.Add(foodCategory.pastry);
            cobModifyCategory.Items.Add(foodCategory.seasonal);
            cobModifyCategory.Items.Add(foodCategory.smoothies);
            cobModifyCategory.Items.Add(foodCategory.snacks);
            cobModifyCategory.Items.Add(foodCategory.tea);
        }

        private bool CreateFood(Food currentFood)
        {
            try
            {
                switch (cobCategories.SelectedIndex)
                //switch case for the caategory for the selected
                //lecture - control structures powerpoint lecture
                {
                    case 0:
                        currentFood.Category = foodCategory.coffee;
                        break;
                    case 1:
                        currentFood.Category = foodCategory.others;
                        break;
                    case 2:
                        currentFood.Category = foodCategory.pastry;
                        break;
                    case 3:
                        currentFood.Category = foodCategory.seasonal;
                        break;
                    case 4:
                        currentFood.Category = foodCategory.smoothies;
                        break;
                    case 5:
                        currentFood.Category = foodCategory.snacks;
                        break;
                    case 6:
                        currentFood.Category = foodCategory.tea;
                        break;
                    default:
                        lblError.Text = "Please enter a category for item!";
                        lblError.Visible = true;
                        return false;
                }

                currentFood.Image = txtImageItem.Text.ToString();

                //cant create an item without cost being null or blank
                //keyword isnullorwhitespace
                //https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-7.0
                if (string.IsNullOrWhiteSpace(txtCostItem.Text))
                {
                    lblError.Text = "Please enter a number for cost!";
                    lblError.Visible = true;
                    return false;
                }

                //validated if the cost is a postive number
                double parsedCost;
                if (!Double.TryParse(txtCostItem.Text, out parsedCost))
                {
                    lblError.Text = "Please enter a postive number for cost!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.Cost = parsedCost;

                //cant create an item without price being null or blank
                if (string.IsNullOrWhiteSpace(txtRetailPrice.Text))
                {
                    lblError.Text = "Please enter a number for price!";
                    lblError.Visible = true;
                    return false;
                }

                //validated if the price is a postive number
                double parsedPrice;
                if (!Double.TryParse(txtRetailPrice.Text, out parsedPrice))
                {
                    lblError.Text = "Please enter a postive number for price!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.Price = parsedPrice;

                //cant create an item without short description being null or blank
                if (string.IsNullOrWhiteSpace(txtShortDescription.Text))
                {
                    lblError.Text = "Please enter a short description for item!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.ShortDescription = txtShortDescription.Text.ToString();

                //cant create an item without long description being null or blank
                if (string.IsNullOrWhiteSpace(txtLongDescription.Text))
                {
                    lblError.Text = "Please enter a long description for item!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.LongDescription = txtLongDescription.Text.ToString();
                
                return true;
            }
            catch (FormatException)
            {
                lblError.Text = "Incomplete field(s)!";
                lblError.Visible = true;
                return false;
            }
        }

        
        private void ltvItemTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            //modal form
            //open the frmmenudisplay
            frmMenuDisplay menuDisplayForm = new frmMenuDisplay();
            menuDisplayForm.ShowDialog();
        }

        private void gpbShortDescription_Enter(object sender, EventArgs e)
        {

        }

        private void btnStore_Click_1(object sender, EventArgs e)
        {
            //new food instance of the Food class
            Food food = new Food();
            if (CreateFood(food))
            {
                menu.Add(food);
                itemDB.InsertItemStatment(food);
                MessageBox.Show("Successfully added food to menu!");
            }
            else
            {
                MessageBox.Show("Cannot add item to the Menu!");
            }
            dgvMenu.DataSource = itemDB.LoadItemTable();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            FrmMenuRemove menuRemoveForm = new FrmMenuRemove();
            menuRemoveForm.ShowDialog();
        }

        private void dgvMenu_SelectionChanged(object sender, EventArgs e)
        {
            //stackover - "How to delete a selected DataGridViewRow and update a connected database table?"
            //https://stackoverflow.com/questions/2084346/how-to-delete-a-selected-datagridviewrow-and-update-a-connected-database-table
            string imageUrl = dgvMenu.CurrentRow.Cells["Image"].Value.ToString();

            try
            {
                pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbxImage.Load(imageUrl);
            }
            catch
            {
                pbxImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbxImage.Load("https://cdn.dribbble.com/users/1012566/screenshots/4187820/media/985748436085f06bb2bd63686ff491a5.jpg");
            }

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        //clear all the textboxes and combo box
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtCostItem.Text = "";
            txtImageItem.Text = "";
            txtLongDescription.Text = "";
            txtRetailPrice.Text = "";
            txtShortDescription.Text = "";
            cobCategories.SelectedIndex = -1;
            lblError.Text = "";
            lblError.Visible = false;
        }

        private void txtLongDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbxImage_Click(object sender, EventArgs e)
        {

        }
        //button modify that update the records
        private void btnModify_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            if (UpdateFood(food))
            {
                //Food food = new Food(cobModifyCategory,txtModifyImage.Text,txtModifyShortDescription.Text,txtModifyLongDescription.Text,txtModifyPrice.Text,txtModifyCost.Text);
                int itemId = Convert.ToInt32(dgvMenu.CurrentRow.Cells["ID"].Value);
                string shortDescription = txtModifyShortDescription.Text;
                string longDescription = txtModifyLongDescription.Text;
                string category = cobModifyCategory.SelectedItem.ToString();
                string image = txtModifyImage.Text;
                double price = double.Parse(txtModifyPrice.Text);
                double cost = double.Parse(txtModifyCost.Text);
                itemDB.UpdateItem(shortDescription, longDescription, category, image, price, cost, itemId);
                dgvMenu.DataSource = itemDB.LoadEverythingItemTable();
                //dgvMenu.Refresh(); 
                MessageBox.Show("Successfully modify food to menu!");
            }
            else
            {
                MessageBox.Show("Cannot modify item to the Menu!");
            }

        }
        private bool UpdateFood(Food currentFood)
        {
            try
            {
                switch (cobModifyCategory.SelectedIndex)
                //switch case for the caategory for the selected
                //lecture - control structures powerpoint lecture
                {
                    case 0:
                        currentFood.Category = foodCategory.coffee;
                        break;
                    case 1:
                        currentFood.Category = foodCategory.others;
                        break;
                    case 2:
                        currentFood.Category = foodCategory.pastry;
                        break;
                    case 3:
                        currentFood.Category = foodCategory.seasonal;
                        break;
                    case 4:
                        currentFood.Category = foodCategory.smoothies;
                        break;
                    case 5:
                        currentFood.Category = foodCategory.snacks;
                        break;
                    case 6:
                        currentFood.Category = foodCategory.tea;
                        break;
                    default:
                        lblError.Text = "Please enter a category for item!";
                        lblError.Visible = true;
                        return false;
                }

                currentFood.Image = txtModifyImage.Text.ToString();

                //cant create an item without cost being null or blank
                //keyword isnullorwhitespace
                //https://learn.microsoft.com/en-us/dotnet/api/system.string.isnullorwhitespace?view=net-7.0
                if (string.IsNullOrWhiteSpace(txtModifyCost.Text))
                {
                    lblError.Text = "Please enter a number for cost!";
                    lblError.Visible = true;
                    return false;
                }

                //validated if the cost is a postive number
                double parsedCost;
                if (!Double.TryParse(txtModifyCost.Text, out parsedCost))
                {
                    lblError.Text = "Please enter a postive number for cost!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.Cost = parsedCost;

                //cant create an item without price being null or blank
                if (string.IsNullOrWhiteSpace(txtModifyPrice.Text))
                {
                    lblError.Text = "Please enter a number for price!";
                    lblError.Visible = true;
                    return false;
                }

                //validated if the price is a postive number
                double parsedPrice;
                if (!Double.TryParse(txtModifyPrice.Text, out parsedPrice))
                {
                    lblError.Text = "Please enter a postive number for price!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.Price = parsedPrice;

                //cant create an item without short description being null or blank
                if (string.IsNullOrWhiteSpace(txtModifyShortDescription.Text))
                {
                    lblError.Text = "Please enter a short description for item!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.ShortDescription = txtModifyShortDescription.Text.ToString();

                //cant create an item without long description being null or blank
                if (string.IsNullOrWhiteSpace(txtModifyLongDescription.Text))
                {
                    lblError.Text = "Please enter a long description for item!";
                    lblError.Visible = true;
                    return false;
                }
                currentFood.LongDescription = txtModifyLongDescription.Text.ToString();

                return true;
            }
            catch (FormatException)
            {
                lblError.Text = "Incomplete field(s)!";
                lblError.Visible = true;
                return false;
            }
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
