/*
Задача 1.
Написать программу-калькулятор, вычисляющую выражения вида 
a + b, a - b, a / b, a * b, введенные из командной строки, и выводящую результат выполнения на экран.
Количество аргументов не ограничено, приоритет операций не учитывается, все вычисления происходят по порядку
*/


namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                double result = Convert.ToInt32(args[0]);
                int i = 1;

                while (i < args.Length)
                {
                    if (args[i] == "+")
                    {
                        result += Convert.ToInt32(args[i + 1]);
                    }
                    if (args[i] == "-")
                    {
                        result -= Convert.ToInt32(args[i + 1]);
                    }
                    if (args[i] == "*")
                    {
                        result *= Convert.ToInt32(args[i + 1]);
                    }
                    if (args[i] == "/")
                    {
                        result /= Convert.ToInt32(args[i + 1]);
                    }

                    i += 1;
                }
                
                Console.WriteLine(string.Join("",args) + " = " + result);
            }
            else
            {
                Console.WriteLine("Need args");
            }
        }
    }
}
