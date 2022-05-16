using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaOsiliaSolis
{
    internal class buque
    {


        private string codigo;
        private string nombre;
        private string pais;
        private int cantidadContainers;
        private int cantidadContainersCargados;
        private int gastoTransporte;
        public List<container> listaContainers;

        public buque(string codigo, string nombre, string pais, int cantidadContainers, int cantidadContainersCargados, int gastoTransporte, List<container> listaContainers)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.pais = pais;
            this.cantidadContainers = cantidadContainers;
            this.cantidadContainersCargados = cantidadContainersCargados;
            this.gastoTransporte = gastoTransporte;
            this.listaContainers = listaContainers;
        }

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Pais { get => pais; set => pais = value; }
        public int CantidadContainers { get => cantidadContainers; set => cantidadContainers = value; }
        public int CantidadContainersCargados { get => cantidadContainersCargados; set => cantidadContainersCargados = value; }
        public int GastoTransporte { get => gastoTransporte; set => gastoTransporte = value; }
        public List<container> ListaContainers { get => listaContainers; set => listaContainers = value; }

        public override string ToString()
        {

            return "Buque: Codigo - " + Codigo + ", Nombre - " + Nombre + ", Pais - " + Pais + ", Capacidad Máxima de Containers - " + CantidadContainers + ", Containers Cargados - " + CantidadContainersCargados + ", Costo de Transporte - " + GastoTransporte + ", Containers Cargados - " + ListaContainers;
        }
    } 

    
    


}



    