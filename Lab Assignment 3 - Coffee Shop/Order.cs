using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3___Coffee_Shop
{
    class Order
    {
        private Customer customer;
        private DateTime orderDateAndTime;
        private string deliveryMethod;
        private string tip;
        private int qty;
        private Food food;
        private Dictionary<Food, int> itemSelected;

        public Order(Customer customer, string deliveryMethod, string tip, int qty, Food food, Dictionary<Food, int> itemSelected)
        {
            this.customer = customer;
            orderDateAndTime = DateTime.Now;
            this.deliveryMethod = deliveryMethod;
            this.tip = tip;
            this.qty = qty;
            this.food = food;
            this.itemSelected = itemSelected;
        }


        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public DateTime OrderDateAndTime
        {
            get { return orderDateAndTime; }
            set { orderDateAndTime = value; }
        }

        public string DeliveryMethod
        {
            get { return deliveryMethod; }
            set { deliveryMethod = value; }
        }

        public string Tip
        {
            get { return tip; }
            set { tip = value; }
        }

        public int StaffQty
        {
            get { return qty; }
            set { qty = value; }
        }

        public Food Food
        {
            get { return food; }
            set { food = value; }
        }

        public Dictionary<Food, int> ItemSelected
        {
            get { return itemSelected;  }
            set { itemSelected = value; }
        }

        public double CalculateSubTotal()
        {
            double subtotal = 0;

            foreach (var product in itemSelected)
            {
                Food foodItem = product.Key;
                int quantity = product.Value;

                subtotal += foodItem.Price * quantity;
            }

            return subtotal;
        }

        public double CalculateTax()
        {
            const double tax = 0.06;
            double subtotal = CalculateSubTotal();

            double total = tax * subtotal;

            return total;
        }

        public double CalculateTotal()
        {
            double subtotal = CalculateSubTotal();
            double tax = CalculateTax();
            double getTip = double.Parse(tip);
            double total = subtotal + tax + getTip;
            return total;
        }

        //Method that display all the selected items , qtys, prices and items in the receipt
        public string GetOrderDisplay()
        {
            //Lecture - string & reference types
            //Stringbuilder is an cllas that creates string objects
            StringBuilder selected = new StringBuilder();

            //var is a loose data type and not strict; dont know what the data type will be and lets the program handle that for you and it will define it later on
            foreach (var item in ItemSelected)
            {
                //Appendline over append - each item will have their separate line so like \n
                //so it will skip line for every item that was selected
                //https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendline?view=net-7.0
                selected.AppendLine($"{item.Key.ShortDescription} - ${item.Key.Price} - Qty:{item.Value}");
            }

            return selected.ToString();
        }

    }
}
