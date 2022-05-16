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
                

            while (salir)
            {
                List<container> listax = new List<container>();
                List<container> listaz = new List<container>();
                buque buqueMAX = new buque("1234321312", "buquex", "chule", 4, 0, 1990, null);
                buque elbuque = new buque("1234321323", "buquek", "argentina", 4, 0, 5990, null);
                container elcontainer = new container("12345", "fruna", 25, 20, true, 20, buqueMAX);
                container container2 = new container("54321", "samsung", 50, 40, false, 30, elbuque);
                container container3 = new container("98765", "lenovo", 60, 20, true, 35, buqueMAX);
                container container4 = new container("56789", "LG", 40, 20, false, 40, elbuque);
                listax.Add(elcontainer);
                listax.Add(container3);
                listaz.Add(container2);
                listaz.Add(container4);

                Console.WriteLine(elcontainer);
                Console.WriteLine(buqueMAX);

                Console.WriteLine(buqueMAX.Codigo);

                Console.WriteLine("Presiona cualquier tecla para salir");
                Console.ReadKey();
                break;





            }



        }

       
    }
}
