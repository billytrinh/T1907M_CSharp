using System;

namespace ConsoleApp1.Session8
{
    public class NumberCounter
    {
        public int x = 0;
        public int y = 0;

        public void Show()
        {
            Console.WriteLine("x = "+x);
            Console.WriteLine("y = "+y);
        }

        public void Change()
        {
            x++;
            y++;
        }
    }
}