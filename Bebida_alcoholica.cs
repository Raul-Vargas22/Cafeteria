using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cafeteria
{
    internal class Bebida_alcoholica : Bebida
    {
        private int CantidaAlcohol;

        public int CantidadAlcohol
        {
            get { return CantidaAlcohol; }
            set { CantidaAlcohol = value; }
        }

        public Bebida_alcoholica(string _nombre, string _tamaño,float _precio, int _cantidadAlcohol) : base(_nombre, _tamaño, _precio)
        {
            CantidaAlcohol = _cantidadAlcohol;
        }

        public override string Preparar()
        {
            return "Estamos preparando un: " + Nombre + " Alcohólica de tamaño: " + Tamaño;
        }

        public string Mensaje()
        {
            return Nombre + $" Con un porcentaje de alcohol de: {CantidadAlcohol}";
        }
    }

}
