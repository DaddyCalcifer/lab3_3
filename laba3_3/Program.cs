using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введите натуральное число для поиска нетривиальных делителей:");
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
                if (num != 0) break;
            }
            if (num < 0)
            {
                Console.WriteLine("Число " + num.ToString() + " не является натуральным (меньше 0) - взят модуль.");
                num *= -1;
                Console.WriteLine(num.ToString());
            }
            Console.WriteLine("Количество нетривиальных делителей: " + CountDeliteli(num));
            Console.Write("Это числа: ");
            int[] dels = Deliteli(num);
            for (int i = 0; i < dels.Length; i++)
            {
                Console.Write(dels[i]);
                if (i < dels.Length - 1) Console.Write(", ");
                else Console.Write(".\n");
            }
        }
        static public int CountDeliteli(int numb)
        {
            int res = 0;
            for (int i = 2; i < numb; i++)
            {
                if ((numb % i) == 0) res++;
            }
            return res;
        }
        static public int[] Deliteli(int numb)
        {
            int [] res = new int[CountDeliteli(numb)];
            int counter = 0;
            for (int i = 2; i < numb; i++)
            {
                if ((numb % i) == 0)
                {
                    res[counter++] = i;
                }
            }
            return res;
        }
    }
}
