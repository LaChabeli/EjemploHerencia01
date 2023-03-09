using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia01
{
    internal class Mamifero : Animal
    {
        public override string tipoAlimentacion()
        {
            string cadena;


            _alimentacion = "";
            cadena = base.tipoAlimentacion();
            cadena += ": Otros seres vivos";

            return cadena;
        }


        public override string Nombre
        {
            get
            {
                return base.Nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value)) throw new Exception("ERROR: Cadena Vacia");
                base.Nombre = value;
            }
        }
    }
}
