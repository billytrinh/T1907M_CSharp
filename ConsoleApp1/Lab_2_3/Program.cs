using System;
using System.Collections.Generic;

namespace ConsoleApp1.Lab_2_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product(1,"san pham 1",3000,2,"anh1","mo ta sp 1",new List<string>());
            //p1.AddGallery("anh 2");
            Fashion f1 = new Fashion(2,"quan ao",1500,3,"fashion1.jpg","mo ta fashion f1",new List<string>(),
                "red",39);
            Diamon d1 = new Diamon(3,"kim cuong 18 cara",15500,1,"kc1.png","Kim cuong nhan tao",new List<string>(),
                18);
            
            Cart c1 = new Cart(1,"Nguyen Van Quyet",0,new List<Product>(),"HG","VN");
            c1.AddProduct(p1);
            c1.AddProduct(f1);
            c1.AddProduct(d1);
            Console.WriteLine("Tong tien phai thanh toan:"+ c1.FinalTotal());

            p1.AddGallery("anh1.jpg");
            p1.AddGallery("anh2.jpg");
            p1.AddGallery("anh3.jpg");

            foreach (string x in p1.Gallery)
            {
                Console.WriteLine(x);
            }

           // p1.Gallery[1] = "anh55.jpg";
           p1[1] = "anh26.png";
           // List,ArrayList tuơng tự
           for (int i = 0; i < p1.Gallery.Count; i++)
           {
               Console.WriteLine(p1[i]);
           }

        }
    }
}