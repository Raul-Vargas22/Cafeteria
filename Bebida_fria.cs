using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cafeteria
{
    internal class Bebida_fria : Bebida
    {
        private int CantidadHielo;

        public int cantidadHielo
        {
            get { return CantidadHielo; }
            set { CantidadHielo = value; }
        }

        public Bebida_fria(string _nombre, string _tamaño,float _precio, int _cantidadHielo): base(_nombre, _tamaño, _precio)
        {
            CantidadHielo = _cantidadHielo;
        }

        public override string Preparar()
        {
            return "Estamos preparando un: " + Nombre + " Frí@ de tamaño: " + Tamaño;
        }

        public string Mensaje()
        {
            return Nombre + " Frío";
        }
    }
}