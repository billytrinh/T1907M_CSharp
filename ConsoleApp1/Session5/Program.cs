using System;

namespace ConsoleApp1.Session5
{
    public class Program
    {
        public static int ProgramCode;
    }

    namespace MyNamespace
    {
        public class MyClass
        {
            public void ShowInfo()
            {
                try
                {
                    int x = 10;
                    int y = 0;
                    Console.WriteLine(x/y);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("done");
            }
        }
    }
}
// tao doi tuong Program cua namespace ConsoleApp1.Session5 -> biet tao tu class nao
namespace ConsoleApp1.Session5.MyNamespace
{
    public class Program
    {
        
    }

    public class DemoProgram
    {
        
    }
}