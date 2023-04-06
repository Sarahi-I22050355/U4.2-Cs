using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U4._2_Cs
{
    internal class Electronico
    {
        private double price;
        private string brand;
        private string model;

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string IVA
        {
            get { return (Price * 0.16 + Price).ToString(); }
        }

        public Electronico()
        {
            price = 0;
            brand = "";
            model = "";
        }

        public Electronico(double Price, string Brand, string Model)
        {
            this.Price = Price;
            this.Brand = Brand;
            this.Model = Model;
        }
    }
}
