using System;
using System.Collections.Generic;

namespace ConsoleApp1.Lab_2_3
{
    public delegate void ShowAlert(string msg);
    public class Cart
    {
        private int id;
        private string customer;
        private double grandTotal;
        private List<Product> listProduct;
        private string city;
        private string country;

        private event ShowAlert AddToCart;
        public Cart(int id, string customer, double grandTotal, List<Product> listProduct, string city, string country)
        {
            this.id = id;
            this.customer = customer;
            this.grandTotal = grandTotal;
            this.listProduct = listProduct;
            this.city = city;
            this.country = country;
            if (AddToCart == null)
            {
                AddToCart += AlertMessage;
            }
        }

        public static void AlertMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        
        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Customer
        {
            get => customer;
            set => customer = value;
        }

        public double GrandTotal
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public List<Product> ListProduct
        {
            get => listProduct;
            set => listProduct = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public bool AddProduct(Product product)
        {
            listProduct.Add(product);
            // them tien trong grandTotal
            // phat su kien
            AddToCart("Da them san pham " + product.Name + " vao gio hang");
            return true;
        }

        public bool RemoveProduct(Product product)
        {
            // tru tien trong grandTotal
            return listProduct.Remove(product);
        }

        public double FinalTotal()
        {
            double grand = 0;
            foreach (Product p in listProduct)
            {
                grand += p.Price; // chay vao ham get trong properties
            }

            grand += ShippingFee(grand);
            this.GrandTotal = grand;// chay vao ham set trong properties
            return grandTotal;
        }

        public double ShippingFee(double grand)
        {
            if(country.Equals("VN") && (city.Equals("HN") || city.Equals("HCM")))
            {
                return grand*0.01;
            }
            
            if (country.Equals("VN"))
            {
                return grand * 0.02;
            }
            
            return grand * 0.05;
            
        }
    }
}