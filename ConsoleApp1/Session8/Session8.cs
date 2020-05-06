using System;
using System.Threading;

namespace ConsoleApp1.Session8
{
    public class Session8
    {
        private int number = 0;
        
        public static void Main(string[] args)
        {
            Thread t1 = new Thread(ThreadRun);
            t1.Start("xin chao");// chay luong moi
            
            Thread t2 = new Thread(new Session8().Run2);
            t2.Start();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("main i = "+i);
                Thread.Sleep(100);
            }
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
    }
}