using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._3._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int number = 0;

            Console.Write("Input a whole number: ");
            number = int.Parse(Console.ReadLine());
            num[0] = number;

            for (int i = 0; i <= num.Length; i++)
            {
                Console.Write("Input a whole number: ");
                number = int.Parse(Console.ReadLine());
               
                for(int j = num.Length-1; j >= 0; j--)
                {
                    if (num[j] != 0)
                    {
                        if (num[j] > number)
                        {
                            num[j + 1] = num[j];
                        }
                        else
                        {
                            num[j + 1] = number;
                        }
                    }
                                        
                }
                foreach (int item in num)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
