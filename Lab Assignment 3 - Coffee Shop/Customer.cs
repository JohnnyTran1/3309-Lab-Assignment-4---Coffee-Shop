using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3___Coffee_Shop
{
    class Customer
    {
        private string name;
        private string phoneNumber;
        private string address;

        public Customer(string name, string phoneNumber, string address)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

    }
}
