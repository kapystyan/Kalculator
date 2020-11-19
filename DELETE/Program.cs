using System;

namespace Kalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Check check = new Check();
            link1:
            Console.Write("Введите первое число: ");
            var userFirstOpperand = Convert.ToString(Console.ReadLine());
            if (check.FirstCheckMetod(userFirstOpperand) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Входная строка имела не верный формат");
                Console.ResetColor();
                goto link1;
            }
            link2:
            Console.Write("Введите оператор: ");
            var userOpperand = Convert.ToString(Console.ReadLine());
            if (userOpperand != "+" && userOpperand != "-" && userOpperand != "/" && userOpperand != "*")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Входная строка имела не верный формат");
                Console.ResetColor();
                goto link2;
            }
            link3:
            Console.Write("Введите второе число: ");
            var userSecondOpperand = Convert.ToString(Console.ReadLine());
            if (check.SecondCheckMetod(userSecondOpperand) == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Входная строка имела не верный формат");
                Console.ResetColor();
                goto link3;
            }

            if (userOpperand == "+")
            {
                Summa(check.FirstCheckMetod(userFirstOpperand), check.SecondCheckMetod(userSecondOpperand));
                goto link1;
            }
            if (userOpperand == "-")
            {
                Minus(check.FirstCheckMetod(userFirstOpperand), check.SecondCheckMetod(userSecondOpperand));
                goto link1;
            }
            if (userOpperand == "/")
            {
                del(check.FirstCheckMetod(userFirstOpperand), check.SecondCheckMetod(userSecondOpperand));
                goto link1;
            }
            if (userOpperand == "*")
            {
                umn(check.FirstCheckMetod(userFirstOpperand), check.SecondCheckMetod(userSecondOpperand));
                goto link1;
            }
        }
        static void Summa(double userFirstOpperand, double userSecondOpperand)
        {
            double d = userFirstOpperand + userSecondOpperand;
            Console.WriteLine("Результат: " + d);
        }
        static void Minus(double userFirstOpperand, double userSecondOpperand)
        {
            double d = userFirstOpperand - userSecondOpperand;
            Console.WriteLine("Результат: " + d);
        }
        static void umn(double userFirstOpperand, double userSecondOpperand)
        {
            double d = userFirstOpperand * userSecondOpperand;
            Console.WriteLine("Результат: " + d);
        }
        static void del(double userFirstOpperand, double userSecondOpperand)
        {
            double d = userFirstOpperand / userSecondOpperand;
            Console.WriteLine("Результат: " + d);
        }
    }
    class Check
    {
        public double FirstCheckMetod(string userFirstOpperand)
        {
            double d;
            if (double.TryParse(userFirstOpperand, out d))
                return d;
            else
                return 0;
        }
        public double SecondCheckMetod(string userSecondOpperand)
        {
            double d;
            if (double.TryParse(userSecondOpperand, out d))
                return d;
            else
                return 0;
        }
    }
}
