using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Assignment_3___Coffee_Shop
{
    public enum foodCategory
    {
        coffee,
        tea,
        smoothies,
        snacks,
        seasonal,
        pastry,
        others,
        none
        
    }
    class Food
    {
        private foodCategory category;
        private string image;
        private double price;
        private double cost;
        private string shortDescription;
        private string longDescription;

        public Food()
        {
            category = foodCategory.none;
            image = "";
            shortDescription = "";
            longDescription = "";
            cost = 0.0;
            price = 0.0;
        }

        public Food(foodCategory category, string image, string shortDescription, string longDescription, double price, double cost)
        {
            this.category = category;
            this.image = image;
            this.price = price;
            this.cost = cost;
            this.shortDescription = shortDescription;
            this.longDescription = longDescription;
        }

        public foodCategory Category
        {
            get { return category; }
            set { category = value; }
        }

        public string Image
        {
            get { return image; }
            set { image = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string ShortDescription
        {
            get { return shortDescription; }
            set { shortDescription = value; }
        }

        public string LongDescription
        {
            get { return longDescription; }
            set { longDescription = value; }
        }

        public override string ToString()
        {
            //Lecture - String & reference types
            //talks about stringbuilder and links mircosft learn more about it
            //https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-7.0&redirectedfrom=MSDN
            var result = new StringBuilder();
            result.Append(this.Category.ToString() + ',');
            result.Append(this.Image.ToString() + ',');
            result.Append(this.Price.ToString() + ',');
            result.Append(this.Cost.ToString() + ',');
            result.Append(this.ShortDescription.ToString() + ',');
            result.Append(this.longDescription.ToString() + ',');

            return base.ToString();
        }


    }

    
}
