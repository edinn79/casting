using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace casting
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  double x = 5;
            int y = 2
                int a = 4;
            double b = a; //implicitni kasting

            double c = 4.0;
            int d = (int)c;// explicitni kasting
            //Console.WriteLine(x / y);

            int nekaVrednost = 10;
            */
            int broj = 0;
            broj++;
            broj--;
            ++broj;
            --broj;
            Console.WriteLine(broj++);//0
            Console.WriteLine(++broj);//2
            Console.WriteLine(broj);//2

            if(broj<3)
            {
                Console.WriteLine("Broj je: " + broj);
                Console.WriteLine("Broj je manji od 3");
            }

            


            Console.ReadLine();

        }
    }
}
