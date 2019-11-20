using System;

namespace TestProjectBGO
{
    public class HomeworkOne
    {
        public bool IsEven(int age)
        {
            if (age % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsAdult(int age)
        {
            if (age > 17)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintResult(string name, int age)
        {
            var result = name + ", " + age + " години - ";

            if (IsAdult(age))
            {
                result += "Пълнолетен";
            }
            else
            {
                result += "Непълнолетен";
            }

            if (IsEven(age))
            {
                result += ", Четно";
            }
            else
            {
                result += ", Нечетно";
            }

            Console.WriteLine(result);
        }
    }
}
