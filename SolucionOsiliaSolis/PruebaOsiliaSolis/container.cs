using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public buque buque;

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

        public container(string codigo, string marca, int capacidadMaxima, byte tamano, bool esRefrigerado, int pesoActual, Buque buque) : this(codigo)
        {
            this.marca = marca;
            this.capacidadMaxima = capacidadMaxima;
            this.tamano = tamano;
            this.esRefrigerado = esRefrigerado;
            this.pesoActual = pesoActual;
            this.buque = buque;
        }
    }
}
