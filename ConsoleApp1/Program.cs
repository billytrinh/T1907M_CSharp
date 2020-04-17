using System;
using System.Collections;
using System.Collections.Generic;

// import

namespace ConsoleApp1 // package
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // print
            string str;
            //str = Console.ReadLine();
            // int no;
            // no = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine(no);
            //TotalNumber();
            dynamic x;// kieu du lieu dong
            x = 20; // x la 1 so nguyen
            Console.WriteLine(x+15);// 35
            x = "xin chao";// x la bien -> dung -> nghe ngo ngan
            Console.WriteLine(x+15);
        }

        static void TotalNumber()
        {
            int numberOne = 2;
            int numberTwo;
            if (numberOne > 2)
            {
                numberTwo = 2;
            }
            else
            {
                numberTwo = 1;
            }

            numberTwo = numberOne > 2 ? 2 : 1;
            bool x = numberOne > numberTwo;
            if (numberOne > numberTwo)
            {
                
            }

            if (x)
            {
                
            }else if (!x)
            {
                
            }
            else
            {
                
            }

            switch (x)
            {
                case  true: break;
                case false: break;
            }
            
            int[] ary = {1,2,3};
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(ary[i]);
            }

            foreach (int y in ary)
            {
                Console.WriteLine(y);
            }
            double[] ary2 = new double[5];
            ary2[0] = 1.112;
            ary2[1] = 2.112;
            ArrayList arrayList = new ArrayList();// it dung
            arrayList.Add(1);
            arrayList.Add("hello");
            List<int> list = new List<int>();
            list.Add(5);// them thong thuong cua list
            list.Add(7);// them thong thuong cua list
            list[1] = 6; // them kieu chi muc (index)
            for (int i = 0; i < ary2.Length; i++)
            {
                Console.WriteLine(ary2[i]);
            }

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            foreach (int k in list)
            {
                Console.WriteLine(k);
            }
            
        }
    }
}