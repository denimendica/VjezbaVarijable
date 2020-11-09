using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_Vježba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte broj = 100;
            int broj2 = -1000;
            char slovo = 'a';
            float broj3 = 3.123f;
            double broj4 = 3.123456789;
            bool rijec = true;
            string rijec2 = "true";

            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}",
                broj, broj2, slovo, broj3, broj4, rijec, rijec2);

            Console.ReadKey();
        }
    }
}
