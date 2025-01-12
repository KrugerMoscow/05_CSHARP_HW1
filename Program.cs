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
                
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Need args");
            }
        }
    }
}
