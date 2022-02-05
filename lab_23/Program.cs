using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab_23
{
    
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FuctAsync(n);

            Console.ReadKey();
        }

        static void Fuct(int n)
        {
            int s = 1;
            for (int i = 1; i < n+1; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }

        static async void FuctAsync(int n)
        {
            await Task.Run(() => Fuct(n));
        }

    }
}

