using System;
using System.Threading;

namespace ConsoleApp1.Session8
{
    public class Session8
    {
        private int number = 0;
        
        public static void Main(string[] args)
        {
            Thread t3 = new Thread(Run3);
            t3.Start(15);
            // Thread t1 = new Thread(ThreadRun);
            // t1.Start("xin chao");// chay luong moi
            //
            // Thread t2 = new Thread(new Session8().Run2);
            // t2.Start();
            // for (int i = 0; i < 100; i++)
            // {
            //     Console.WriteLine("main i = "+i);
            //     Thread.Sleep(100);
            // }
        }

        public static void ThreadRun(object o) // ko co tham so hoac  1 tham so object
        {
            string msg = (string) o;// down casting
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(msg+" i = "+i);
                Thread.Sleep(100);
            }
        }

        public void Run2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(" xyz = "+(number+=2));
                Thread.Sleep(100);
            }
        }

        public static void Run3(object o)
        {
            int n = (int) o;
            for (int i = n-1; i >=0 ; i--)
            {
                for (int j = 59; j >= 0; j--)
                {
                    // keyword: number format 01 02 in C# 
                    Console.WriteLine(i.ToString("D2")+":"+j.ToString("D2"));
                    Thread.Sleep(10);
                }
            }
            Console.WriteLine("Boom...");
        }
    }
}