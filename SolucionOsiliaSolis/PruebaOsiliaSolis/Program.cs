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
                buque buqueMAX = new buque("1234321312", "buquex", "chile", 4, 0, 1990, null);
                buque elbuque = new buque("1234321323", "buquek", "argentina", 4, 0, 5990, null);
                container elcontainer = new container("12345", "fruna", 500, 20, true, 300, buqueMAX);
                container container2 = new container("54321", "samsung", 500, 40, false, 300, elbuque);
                container container3 = new container("98765", "lenovo", 500, 20, true, 350, buqueMAX);
                container container4 = new container("56789", "LG", 400, 20, false, 400, elbuque);
                listax.Add(elcontainer);
                listax.Add(container3);
                listaz.Add(container2);
                listaz.Add(container4);

                buqueMAX.ListaContainers = listax;

                int pesoasacar = 200;
                int pesoasacar2 = 1000;

               
                Console.WriteLine("Se calculará el costo de envío del buque: buqueMAX" );
                Console.WriteLine("");
                calcularEnvio(buqueMAX.GastoTransporte,
                              buqueMAX.CantidadContainers,
                              buqueMAX.ListaContainers);
                Console.WriteLine("");

                Console.WriteLine("Peso de container 1: " + elcontainer.PesoActual);
                Console.WriteLine("Se removerá peso del Container 1: ");
                sacarPeso(pesoasacar, elcontainer);
                Console.WriteLine("Peso de container 1: " + elcontainer.PesoActual);
                Console.WriteLine("");
                Console.WriteLine("Peso de container 2: " + container2.PesoActual);
                Console.WriteLine("Se removerá peso del Container 2: ");
                sacarPeso(pesoasacar2, container2);
                Console.WriteLine("Peso de container 2: " + container2.PesoActual);

                Console.WriteLine("");
                Console.WriteLine("Se calcularán los costos de aduana del container número 3");
                calcularAduana(container3);


                Console.WriteLine("Presiona cualquier tecla para salir");
                Console.ReadKey();
                break;



            }
        }
        
        private static void calcularEnvio(int gasto, int capacidad, List<container> cont)
        {
            int small = 0;
            int big = 0;
            int div = gasto / capacidad;
            int total = 0;
            for(int i = 0; i < cont.Count; i++)
            {

                if (cont[i].Tamano == 20)
                {
                    small++;
                }
                if (cont[i].Tamano == 40)
                {
                    big++;
                }


            }

            total = div + (3500 * small) + (5000 * big);
            
            Console.WriteLine("El gasto de Envío es: " + total);
        }

        private static void sacarPeso(int pesoMenos, container cont)
        {
           int resultado = cont.PesoActual - pesoMenos;
            if(resultado < 0)
            {
                Console.WriteLine("El peso ingresado no es valido, Resultado negativo");
            }
            else
            {
                cont.PesoActual = resultado;
                Console.WriteLine("El peso ha sido removido");
            }

        }

        private static void calcularAduana(container cont)
        {
           int total = 0;
           int container = cont.PesoActual * 5;
           total += container;
            Console.WriteLine("El total del costo de aduanas del container " + cont.Codigo + " es: " + total);
        }
            
        
    }
}
