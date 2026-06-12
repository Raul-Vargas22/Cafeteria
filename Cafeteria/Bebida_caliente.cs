using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cafeteria
{
    internal class Bebida_caliente : Bebida
    {
        private int Temperatura;

        public int temperatura
        {
            get { return Temperatura; }
            set { Temperatura = value; }
        }

        public Bebida_caliente(string _nombre, string _tamaño,float _precio, int _temperatura) : base(_nombre, _tamaño, _precio)
        {
            Temperatura = _temperatura;
        }

        public override string Preparar()
        {
            return $"Estamos preparando un: {Nombre} Caliente de tamaño: {Tamaño}";
        }

        public string Mensaje()
        {
            return $"{Nombre} Caliente";
        }
    }
}
