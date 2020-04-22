using System.Collections.Generic;

namespace ConsoleApp1.Lab_2_3
{
    public class Diamon:Product
    {
        private uint cara;

        public Diamon(int id, string name, uint qty, string image, string desc, List<string> gallery, uint cara
        ):base(id, name, qty, image, desc, gallery)
        {
            this.cara = cara;
        }
        
        public bool IsReal()
        {
            if(cara>5) return true;
            return false;
        }
    }
}