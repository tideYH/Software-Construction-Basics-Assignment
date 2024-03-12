using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    internal class homework24
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 4] {
            {1,2,3,4 },
            {5,1,2,3 },
            {6,5,1,3 }
            };
            
          
            if (isToplitz(myArray))
            {
                Console.WriteLine("这个矩阵是所需的特殊矩阵");
            }
            else
            {
                Console.WriteLine("这个矩阵不是所需矩阵");
            }
        }

        static bool isToplitz(int[ ,] tmp)
        {
            int[,] arr = tmp;
            int rowNum = arr.GetLength(0);
            int colNum = arr.GetLength(1);

            
            for (int i = 0; i < rowNum; i++)//行，从第一个检验到最后一个，逐次递增
            {
                int m = i,n = 0;//里面使用一个while循环结构检验下一个是不是相等
                while (n < colNum-1&&m < rowNum-1) {
                    if (arr[m,n] != arr[m + 1,n + 1])
                    {
                        return false;                   
                    }
                    m++; n++;
                }
            }

            for(int j = 1; j < colNum; j++)//列，排除第一个开始检验
            {
                int m = 0,n = j;
                while (n < colNum-1&&m < rowNum-1) {
                    if (arr[m, n] != arr[m + 1, n + 1])
                    {
                        return false;
                    }
                    m++; n++;
                }
            }
            return true;
        }
    }
}

