using System;
using System.Text;

namespace TestProjectBGO
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Въведете име : ");
            var fullName = Convert.ToString(Console.ReadLine());

            Console.Write("Въведете години : ");
            var age = Convert.ToInt32(Console.ReadLine());

            var data = new HomeworkOne();
            data.PrintResult(fullName,age);
        }
    }
}
