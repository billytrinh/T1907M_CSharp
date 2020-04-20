namespace ConsoleApp1.Session3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Man m = new Man();
            m.Running();
            Woman wm = new Woman();
            wm.Running();
            m.SayHello();
            m.SayHello("Chào em!");
            //Human hm = new Human();
        }
    }
}