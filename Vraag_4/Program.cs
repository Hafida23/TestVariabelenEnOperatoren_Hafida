using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double restU;
            double restM;
            double restS;
            Console.WriteLine("voer een aantal om een aantal seconden te gehelen : ");
            int aantal = int.Parse(Console.ReadLine());
            if(aantal%3600 != 0)
            {
                restU = (double)aantal / 3600;
                restM = (restU - (int)restU) * 60;
                restS = (restM - (int)restM )* 60;
                
                Console.WriteLine($"U:{(int)restU}, M:{(int)restM}, S:{(int)restS}");
            }




        }
    }
}
