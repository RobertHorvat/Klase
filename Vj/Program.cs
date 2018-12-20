using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vj
{
    class Program
    {
        static void Main(string[] args)
        {
            Krug k1;
            k1 = new Krug();
            k1.ZadajPolumjer(5);
            Console.WriteLine(k1.VratiOpis());
            Console.ReadLine();

            Kvadrat kvad1;
            kvad1 = new Kvadrat();
            kvad1.ZadajStranicu(6);
            Console.WriteLine(kvad1.VratiOpis());
            Console.ReadLine();

            Pravokutnik p1;
            p1 = new Pravokutnik();
            p1.ZadajStranicu1(3);
            p1.ZadajStranicu2(8);
            Console.WriteLine(p1.VratiOpis());
            Console.ReadLine();

            Trokut t1;
            t1 = new Trokut();
            t1.ZadajStranicu1(3);
            t1.ZadajStranicu2(4);
            t1.ZadajStranicu3(5);
            t1.ZadajVisinu(3);
            Console.WriteLine(t1.VratiOpis());
            Console.ReadLine();
        }
    }
}
