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
    public partial class frmCustomerReceipt : Form
    {
        private Order order;
        internal frmCustomerReceipt(Order order)
        {
            InitializeComponent();
            this.order = order;
            DisplayOrderDetails();
        }

        private void DisplayOrderDetails()
        {
            lblDisplayPhoneNumber.Text = order.Customer.PhoneNumber;
            lblDisplayAddress.Text = order.Customer.Address;
            lblDisplayName.Text = order.Customer.Name;
            lblDisplayOrder.Text = order.DeliveryMethod;
            lblDisplayTip.Text = $"${order.Tip:0.00}";
            lblDisplaySubTotal.Text = $"${order.CalculateSubTotal():0.00}".ToString();
            lblDisplayDateAndTime.Text = order.OrderDateAndTime.ToString();
            lblDisplayTax.Text = $"${order.CalculateTax():0.00}".ToString();
            lblDisplayTotal.Text = $"${order.CalculateTotal():0.00}".ToString();
            lblDisplayItems.Text = order.GetOrderDisplay();

        }
            private void btnNewOrder_Click(object sender, EventArgs e)
        {
            frmCustomerOrder startNewOrderForm = new frmCustomerOrder();
            startNewOrderForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
