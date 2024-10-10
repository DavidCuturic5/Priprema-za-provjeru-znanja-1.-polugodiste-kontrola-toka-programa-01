using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolaTokaPrograma1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite vrijednost stranice x:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost stranice y:");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unesite vrijednost stranice z:");
            int z = Convert.ToInt32(Console.ReadLine());


            if (x <= 0 || y <= 0 || z <= 0)
            {
                Console.WriteLine("Vrijednosti stranica moraju biti veće od 0.");
                Console.ReadKey();
            }


            if (Pravokutnitrokut(x, y, z))
            {
                Console.WriteLine("Trokut je pravokutan");
            }
            else
            {
                Console.WriteLine("Trokut nije pravokutan");
            }
            Console.ReadKey();
        }
        static bool Pravokutnitrokut(int x, int y, int z)
        {
            return (x * x + y * y == z * z) || (x * x + z * z == y * y) || (y * y + z * z == x * x);
        }







    }
}
    
       
   
