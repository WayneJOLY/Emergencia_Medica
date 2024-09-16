using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    public class CPersona
    {
        string nombre;
        string apellido;
        bool estaEnUnaConformacion;
        string legajo;

        public CPersona(string nombre, string apellido,string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string Nombre { get {  return nombre; } }
        public string getLegajo() { return this.legajo; }
                public void setEstaEnUnaConformacion(bool EstaEnUnaConformacion) { this.estaEnUnaConformacion = EstaEnUnaConformacion; }


        public bool getEstaEnUnaConformacion() { return this.estaEnUnaConformacion; }
        public override string ToString()
        {
            return "\n Nombre :"+ this.nombre+"\n Apellido :" +this.apellido +"\n Legajo :" + this.legajo;
        }
    }
}
