using System;

namespace ConsoleApp1.Lab6
{
    public class Lab6
    {
        public static void Main(string[] args)
        {
            int choose;
            do
            {
                ShowMenu();
                choose = ReadNumber();
                if (choose > 0 && choose < 5)
                {
                    Console.WriteLine("nhap so thu nhat:");
                    int no1 = ReadNumber();
                    Console.WriteLine("nhap so thu hai:");
                    int no2 = ReadNumber();
                    MathNumber mn = Calc.GetFunction(choose);
                    switch (choose)
                    {
                        case 1: Console.WriteLine("Tong 2 so:"+mn(no1,no2));
                            break;
                        case 2: Console.WriteLine("Hieu 2 so:"+mn(no1,no2));
                            break;
                        case 3: Console.WriteLine("Tich 2 so:"+mn(no1,no2));
                            break;
                        case 4: Console.WriteLine("Thuong 2 so:"+mn(no1,no2));
                            break;
                    }
                }
            } while (choose != 0);

        }

        public static void ShowMenu()
        {
            Console.WriteLine("Lua chon chuc nang:");
            Console.WriteLine("1. Cong");
            Console.WriteLine("2. Tru");
            Console.WriteLine("3. Nhan");
            Console.WriteLine("4. Chia");
            Console.WriteLine("0. Thoat");
        }

        public static int ReadNumber()
        {
            return Convert.ToInt32(Console.ReadLine())
                ;
        }
    }
}