using System;

namespace ConsoleApp1.Session2
{
    public class Session2
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();// s1 la 1 doi tuong tao ra tu lop Student
             // new Student() moi la doi tuong --> tạo 1 ô nhớ chứa: name, age, function showInfo
             s1.ShowName();
             Social.Hello();// ClassName.MethodName()
             Console.WriteLine(Social.FirstWeekOfYear+10);// ClassName.VarName
        }
        // MVC
    }
}