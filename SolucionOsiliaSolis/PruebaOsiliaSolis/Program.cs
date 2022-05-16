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
                container contain = new container();
                List<container> listax = new List<container>();
                List<container> listaz = new List<container>();
                buque buqueMAX = new buque("35899", "buquemax", "chile", 4, 0, 1990, null);
                buque elbuque = new buque("35877", "elbuque", "argentina", 4, 0, 5990, null);
                container elcontainer = new container("12345", "fruna", 500, 20, true, 300, buqueMAX);
                container container2 = new container("54321", "samsung", 500, 40, false, 300, elbuque);
                container container3 = new container("98765", "lenovo", 500, 20, true, 350, buqueMAX);
                container container4 = new container("56789", "LG", 400, 20, false, 400, elbuque);
                listax.Add(elcontainer);
                listax.Add(container3);
                listaz.Add(container2);
                listaz.Add(container4);
                buqueMAX.ListaContainers = listax;
                elbuque.ListaContainers = listaz;
                Console.WriteLine("Buques:");
                Console.WriteLine(buqueMAX);
                Console.WriteLine(elbuque);
                Console.WriteLine("");
                Console.WriteLine("Containers:");
                Console.WriteLine(elcontainer);
                Console.WriteLine(container2);
                Console.WriteLine(container3);
                Console.WriteLine(container4);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Se subirán los containers a los buques");

                subirContainer(elbuque);
                subirContainer(buqueMAX);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                int pesoasacar = 200;
                int pesoaagregar = 1000;

                Console.WriteLine("Se calculará los costos de envío de los buques y sus containers: " );
                Console.WriteLine("");
                calcularEnvio(buqueMAX);
                Console.WriteLine("");
                Console.WriteLine("");
                calcularEnvio(elbuque);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Se calcularán los costos de aduana del container número 3");
                calcularAduana(container3);
                Console.WriteLine("");
                Console.WriteLine("");    
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Se tratará de insertar 2000 kilos al container 4");
                contain.puedeSubir(pesoaagregar, container4.CapacidadMaxima, container4.PesoActual);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Peso inicial de container 1: " + elcontainer.PesoActual);
                Console.WriteLine("Se removerá peso del Container 1: ");
                sacarPeso(pesoasacar, elcontainer);
                Console.WriteLine("Peso de container 1: " + elcontainer.PesoActual);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Presiona cualquier tecla para salir");
                Console.ReadKey();
                break;



            }
        }
        
        private static void calcularEnvio(buque b)
        {
            int small = 0;
            int big = 0;
            int div = b.GastoTransporte / b.CantidadContainers;
            int total = 0;
            for(int i = 0; i < b.ListaContainers.Count; i++)
            {

                if (b.ListaContainers[i].Tamano == 20)
                {
                    small++;
                    Console.WriteLine("El container: " + b.ListaContainers[i].Codigo + " pagará $3.500 de envío");
                }
                if (b.ListaContainers[i].Tamano == 40)
                {
                    big++;
                    Console.WriteLine("El container: " + b.ListaContainers[i].Codigo + " pagará $9.000 de envío");
                }


            }

            total = div + (3500 * small) + (9000 * big);
            
            Console.WriteLine("El gasto de Envío del buque " + b.Nombre + " es: $" + total);
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

        private static void subirContainer(buque b)
        {
            int carga = b.CantidadContainersCargados;
            int cantidad = 0;
            int big = 0;
            int small = 0;
            for (int i = 0; i < b.ListaContainers.Count; i++)
            {
                if(b.ListaContainers[i].Tamano == 20)
                {
                    small++;
                }else if(b.ListaContainers[i].Tamano == 40)
                {
                    big++;
                }


            }

            cantidad = (small) + (big * 2);
            if (cantidad > b.CantidadContainers)
            {
                Console.WriteLine("La cantidad a subir excede la capacidad");
            }
            else
            {
                carga = cantidad;
                Console.WriteLine("La cantidad de containers cargados en el buque " + b.Nombre + " es: " + cantidad);
            }
            
        }
        
    }
}
