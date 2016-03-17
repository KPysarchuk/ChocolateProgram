using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chocolates;

namespace ConsoleApplicationChocolate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the quantity of chocolate stashes:");
            int n = Convert.ToInt32(Console.ReadLine());
            ChocolateStashes[] chocolatearr = new ChocolateStashes[n];
            for (int i = 0; i < n; i++)
            {
                chocolatearr[i] = new ChocolateStashes();
            }
            Console.WriteLine("Enter the quantity of chocolates in each stash through the space:");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(arr_temp, Int32.Parse);
            for (int i = 0; i < n; i++)
            {
                chocolatearr[i].Quantity = a[i];
            }
            //Games.GameOfChocolate(n, chocolatearr);
            Console.WriteLine(Games.GameOfChocolate(n, chocolatearr));

        }
    }
}
