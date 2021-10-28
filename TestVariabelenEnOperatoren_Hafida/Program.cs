using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVariabelenEnOperatoren_Hafida
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a = 20;
            decimal b = 4.1m;
            int c = 6;
            Console.WriteLine(a + (double)b+(double)c);
            Console.WriteLine((decimal)a + b+(decimal)c);
            Console.WriteLine((int)a + (int)b + c);

            string naam = "hafida";
            Console.WriteLine($"de naam is {naam}");
        }
    }
}
