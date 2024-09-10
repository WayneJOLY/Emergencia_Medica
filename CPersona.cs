using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    internal class CPersona
    {
        string nombre;
        string apellido;

        public CPersona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get {  return nombre; } }

        public override string ToString()
        {
            return "\n Nombre :"+ this.nombre+"\n Apellido :" +this.apellido;
        }
    }
}
