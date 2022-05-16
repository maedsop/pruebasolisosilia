using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOsiliaSolis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                bool salir = true;
                string opcion = "";

            while (salir)
            {
                List<container> listax = new List<container>();
                buque buqueMAX = new buque("12342", "buquex", "chule", 4, 2, 1990, listax);

                Console.WriteLine(buqueMAX.Codigo);

                Console.WriteLine("Presiona cualquier tecla para salir");
                Console.ReadKey();
                break;





            }



        }

       
    }
}
