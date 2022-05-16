using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PruebaOsiliaSolis.buque;

namespace PruebaOsiliaSolis
{
    internal class container
    {
        private string codigo;
        private string marca;
        private int capacidadMaxima;
        private byte tamano;
        private bool esRefrigerado;
        private int pesoActual;
        public buque Buque;

        public string Codigo { get => codigo; }
        public string Marca { get => marca; set => marca = value;  }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public byte Tamano{ get => tamano; set => tamano = value; }
        public bool EsRefrigerado { get => esRefrigerado;}
        public int PesoActual { get => pesoActual; set => pesoActual = value; }

        public container(string codigocontainer)
        {
            this.codigo = codigocontainer;
        }

        public container(string codigo, string marca, int capacidadMaxima, byte tamano, bool esRefrigerado, int pesoActual, buque Buque) : this(codigo)
        {
            this.marca = marca;
            this.capacidadMaxima = capacidadMaxima;
            this.tamano = tamano;
            this.esRefrigerado = esRefrigerado;
           if(pesoActual < 0)
            {
                Console.WriteLine("Ingrese un peso válido (Numero Positivo)");
            } else if(pesoActual > capacidadMaxima){
                Console.WriteLine("Peso excede capacidad máxima del container");
            }
            else {
                this.pesoActual = pesoActual;
            }
            this.Buque = Buque;
        }

        public string Refri(bool esRefri)
        {
            string refrigerado = "";
            if (esRefri == true)
            {
                refrigerado = "Si";
            }
            else
            {
                refrigerado = "No";
            }
            return refrigerado;
        }

        public override string ToString()
        {
            return "Container: Codigo - " + Codigo + ", Marca - " + Marca + ", Capacidad Máxima - " + CapacidadMaxima + " kilos, Tamaño - " + Tamano + " pies, Refrigeración - " + Refri(esRefrigerado) + ", Peso Actual - " + PesoActual + " kilos, Buque Asociado - " + Buque.Nombre;
                }

    }
}
