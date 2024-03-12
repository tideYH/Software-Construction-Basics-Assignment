using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class homework23
    {
        static void Main(string[] args)
        {
            Console.WriteLine(2);
            for(int i = 3; i <= 100; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0) break;
                    if (j == i - 1)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
