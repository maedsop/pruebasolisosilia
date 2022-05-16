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
                    Console.WriteLine("1. Agregar mascota");
                    Console.WriteLine("2. Buscar mascota");
                    Console.WriteLine("3. Borrar mascota");
                    Console.WriteLine("4. Modificar mascota");
                    Console.WriteLine("5. Salir");

                    opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1":
                            Console.WriteLine("Ingreso de nueva mascota");
                        break;

                }



                

                 }



        }

       
    }
}
