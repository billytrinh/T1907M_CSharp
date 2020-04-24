using System;
using System.Collections.Generic;

namespace ConsoleApp1.Assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<KhachHangVietNam> listVN = new List<KhachHangVietNam>();
            listVN.Add(new KhachHangVietNam(1,"nguyễn văn an","01/2019",155,"sinh hoạt"));
            List<KhachHangNuocNgoai> listNN = new List<KhachHangNuocNgoai>();
            listNN.Add(new KhachHangNuocNgoai(2,"Alex","01/2019",78,"US"));
            listNN.Add(new KhachHangNuocNgoai(3,"Micheal","01/2019",122,"UK"));
            listVN.Add(new KhachHangVietNam(4,"Lê Minh Anh","01/2019",255,"sinh hoạt"));
            int totalVN = 0;
            foreach (KhachHangVietNam x in listVN)
            {
                totalVN += x.ThanhTien();
            }

            int totalNN = 0;
            foreach (KhachHangNuocNgoai x in listNN)
            {
                totalNN += x.ThanhTien();
            }
            Console.WriteLine("VN: "+totalVN);
            Console.WriteLine("NN: "+totalNN);
            Console.WriteLine("Trung binh:");
            Console.WriteLine("VN: "+((float)totalVN/listVN.Count));
            Console.WriteLine("NN: "+((float)totalNN/listNN.Count));
            Console.WriteLine("Hoa don thang 1/2019");
            foreach (KhachHangVietNam x in listVN)
            {
                if (x.BillDate.Equals("01/2019"))
                {
                    x.ShowBill();
                }
            }
            foreach (KhachHangNuocNgoai x in listNN)
            {
                if (x.BillDate.Equals("01/2019"))
                {
                    x.ShowBill();
                }
            }
        }
    }
}