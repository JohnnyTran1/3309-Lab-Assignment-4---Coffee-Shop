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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            //open the employee form
            frmEmployeeCreate employeeFrom = new frmEmployeeCreate();
            //modal form
            employeeFrom.ShowDialog();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            //open the menu display form
            frmMenuDisplay viewForm = new frmMenuDisplay();
            //modal form
            viewForm.ShowDialog();
        }
    }
}
