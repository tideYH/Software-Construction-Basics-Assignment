using System;

namespace Ca
{
    class Program11
    {
        static void Main(string[] args)
        {

            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            string fun = Console.ReadLine();
            GetResualt(fun, num1, num2);
            Console.ReadLine();
        }


        static void GetResualt(string fun, double num1, double num2)
        {
            double res = 0;
            string yun = "";
            switch (fun)
            {
                case "1":
                    res = num1 + num2;
                    yun = "+";
                    break;
                case "2":
                    res = num1 - num2;
                    yun = "-";
                    break;
                case "3":
                    res = num1 * num2;
                    yun = "x";
                    break;
                case "4":
                    res = num1 / num2;
                    yun = "÷";
                    break;
                case "5":
                    res = num1 % num2;
                    yun = "%";
                    break;
                default:
                    string str = Console.ReadLine();
                    GetResualt(str, num1, num2);
                    return;
            }
            Console.WriteLine("{0}{3}{1}={2}", num1, num2, res, yun);
        }
    }
}
