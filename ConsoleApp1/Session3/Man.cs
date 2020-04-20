using System;

namespace ConsoleApp1.Session3
{
    public class Man: Human,IHuman
    {
        public override void AddFriend()
        {
            
        }

        public void Alo()
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine("Hello everybody!");
        }

        public void SayHello(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}