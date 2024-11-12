using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Assignment_3___Coffee_Shop
{
    public partial class FrmMenuRemove : Form
    {
        public FrmMenuRemove()
        {
            InitializeComponent();
        }
        ItemDB itemDB = new ItemDB();

        //pre load the combobox and ggatagridview
        private void FrmMenuRemove_Load(object sender, EventArgs e)
        {
            dgvMenu.DataSource = itemDB.LoadEverythingItemTable();
            cboSearchCategory.DataSource = itemDB.LoadCategoryTable();
            cboSearchCategory.DisplayMember = "Category";
            cboSearchCategory.ValueMember = "Category";
        }

        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        //button that remove a selected row and then refresh the datagridview
        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            string deleteItem = dgvMenu.SelectedCells[0].Value.ToString();
            int deleteItemId = int.Parse(deleteItem);
            itemDB.DeleteItem(deleteItemId);
            dgvMenu.DataSource = itemDB.LoadEverythingItemTable();
        }

        //button search that gets the category value and then called the method from the itemDB
        //and then update the datagridview that has similar item(s) 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectCateogry = cboSearchCategory.SelectedValue.ToString();
            dgvMenu.DataSource = itemDB.LoadOnlySearchCategoryTable(selectCateogry);

            
        }

        //load back to the preload record if there wasnt any delete records
        private void btnReset_Click(object sender, EventArgs e)
        {
            dgvMenu.DataSource = itemDB.LoadItemTable();

        }
    }
}
