using System;

namespace ConsoleApp1.Session7
{
    public delegate void ButtonHander(string msg);
    
    public class EventDemo
    {
        public event ButtonHander OnClick;

        public void ClickButton()
        {
            Console.WriteLine("Button clicked!");
            DateTime now = DateTime.Now;
            if (OnClick == null)
            {
                OnClick += ShowAlert;
            }

            OnClick("User clicked at: " + now);
        }

        public static void ShowAlert(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}