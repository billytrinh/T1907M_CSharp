using System;
using System.Data;

namespace ConsoleApp1.Assignment4
{
    public class KhachHang
    {
        protected int id;
        protected string name;
        protected string billDate;
        protected int number;

        public KhachHang()
        {
        }

        public KhachHang(int id, string name, string billDate, int number)
        {
            this.id = id;
            this.name = name;
            this.billDate = billDate;
            this.number = number;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string BillDate
        {
            get => billDate;
            set => billDate = value;
        }

        public int Number
        {
            get => number;
            set => number = value;
        }

        public virtual int ThanhTien()
        {
            if (Number <= 50)
            {
                return Number * 1000;
            }else if (Number <= 100)
            {
                return 50 * 1000 + (Number - 50) * 1200;
            }else if (Number <= 200)
            {
                return 50 * 1000+ 50*1200 + (Number - 100) * 1500;
            }
            else
            {
                return 50 * 1000+ 50*1200 + 100* 1500+ (Number - 200)*2000 ;
            }
        }

        public void ShowBill()
        {
            Console.WriteLine("ID: "+Id);
            Console.WriteLine("Name: "+Name);
            Console.WriteLine("Total: "+ThanhTien());
        }
    }
}