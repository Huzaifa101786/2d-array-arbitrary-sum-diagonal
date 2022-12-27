using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_t2
{
    internal class Program
    {

    
    public static void Main(string[] args)
    {
        
            int[,] arr = new int[6,6];
            int value;
            int sum = 0;
            int[,] vals = new int[4,4];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //Console.Write($"Enter value at [{i}][{j}] index : ");
                    //value = Convert.ToInt32(Console.ReadLine());
                    arr[i,j] = i;
                }
            }


            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (i < 4 && j<4)
                    {
                        vals[i,j] = arr[i, j] + arr[i, j + 1] + arr[i, j + 2]
                        + arr[i + 1, j + 1] + arr[i + 2, j] + arr[i + 2, j + 1]
                        + arr[i + 2, j + 2];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            sum = vals.Cast<int>().Max();
            Console.WriteLine(sum);
            Console.ReadKey();


        }
    }
}
