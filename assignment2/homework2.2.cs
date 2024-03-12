using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace test2
{
    internal class homework22
    {

        static void Main(string[] args)
        {
            int[] Array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int Max = -1;
            int Min = 100;
            int sum = 0;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Max) Max = Array[i];
                if (Array[i] < Min) Min = Array[i];
                sum += Array[i];
            }
            Console.WriteLine(Max);
            Console.WriteLine(Min);
            Console.WriteLine(sum);
            double Aver = sum / Array.Length;
            Console.WriteLine(Aver);
        }
    }
}