using System;

namespace ConsoleApp1.Session6
{
    // khai báo 1 delegate trả về int và có 2 tham số int
    public delegate int IntegerToInteger(int a, int b);

    public class Program
    {
        public static void Main(string[] args)
        {
            // tạo 1 đối tượng delegate
            IntegerToInteger ii = new IntegerToInteger(Calculator.Add);// tham chieu den ô nhớ của hàm
            ii += Calculator.Subtract;// nạp thêm hàm vào chuỗi thực hiện của delegate - multicast
            ii += new Calculator().division;
            int a = ii(5, 2);// thực thi các hàm được nạp vào delegate
            Console.WriteLine("a = "+a);
            // Calculator.Add(2 , 5);
            // Calculator.Subtract(2 , 5);
            // // luon can chay 2 dong voi moi cap so
            // Calculator.Add(7 , 3);
            // Calculator.Subtract(7 , 3);
            TaxMoney tm = TaxCalc.GetTax("VN");// tm la 1 delegate;
            float tax = tm(100000000);
            Console.WriteLine("Thue phai nop: "+tax);
            
            // tạo 1 hàm ẩn danh bằng delegate
            TaxMoney tm2 = delegate(float salary) { return salary * 40 / 100; };
            float frTax = tm2(10000);
            Console.WriteLine("Thue tai Phap: "+frTax);
        }
        
        
    }
}