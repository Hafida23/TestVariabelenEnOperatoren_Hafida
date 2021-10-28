using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vraag_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxScore=10;
            int som = 0;
            double gemiddelde;
            bool stayInLoop = true;

            while (stayInLoop)
            {
                Console.Write("voer het eerste score : ");
                int scoreVak1 = int.Parse(Console.ReadLine());
                Console.Write("voer de tweede score : ");
                int scoreVak2 = int.Parse(Console.ReadLine());
                Console.Write("voer de derde score : ");
                int scoreVak3 = int.Parse(Console.ReadLine());
                Console.Write("voer de vierde score : ");
                int scoreVak4 = int.Parse(Console.ReadLine());

                if (scoreVak1 <= maxScore && scoreVak2 <= maxScore && scoreVak3 <= maxScore && scoreVak4 <=10 )
                {
                  
                    som = scoreVak1+scoreVak2+scoreVak3+scoreVak4;
                    gemiddelde =(double)som/4*10;

                    Console.WriteLine($"Het gemiddelde is {gemiddelde} %");
                }
                else break;

                Console.WriteLine("Wilt u voer the score voor endre student ? ja of nee");
                string aantword=Console.ReadLine();
                if (aantword == "nee")
                    stayInLoop=false;


            }

        }
    }
}
