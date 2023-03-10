using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerencia01
{
    internal class Animal
    {
        private int TAM_NOMBRE = 20;

        protected string _alimentacion = "Comida";
        private string _nombre;

        public virtual string Nombre
        {
            get { return _nombre; }
            set 
            {

                if (value.Length > TAM_NOMBRE) throw new Exception("ERROR");

                _nombre = value; 
            }
        }

        public virtual string tipoAlimentacion()
        {
            return _alimentacion;
        }
    }
}
