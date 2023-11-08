using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pripremaZaOcjenskuVjezbu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            unos:

            Console.WriteLine("Upišite vrijednost stranica pravokutnog trokuta (vrijednosti moraju biti veće od 0): ");
            
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            if(a <= 0 || b <= 0 || c <= 0)
            {
                Console.WriteLine("Unešene vrijednosti nisu ispravne molim vas pokušajte ponovno!");
                a = 0;
                b = 0;
                c = 0;
                goto unos;
            }

            if(a > b && a > c)
            {
                if (Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    Console.WriteLine("Trokut je pravokutan");
                }

                else
                {
                    Console.WriteLine("Trokut nije pravokutan");
                }
            }

            else if(b > a && b > c)
            {
                if(Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
                {
                    Console.WriteLine("Trokut je parvokutan");
                }

                else
                {
                    Console.WriteLine("Trokut nije pravokutan");
                }
            }

            else if (c > a && c > b)
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                {
                    Console.WriteLine("Trokut je parvokutan");
                }

                else
                {
                    Console.WriteLine("Trolut nije pravokutan");
                }
            }

            Console.ReadKey();

        }
    }
}
