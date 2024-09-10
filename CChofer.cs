using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    internal class CChofer:CPersona
    {

        string codigo;
        uint numero_de_Licencia;
        string distrito;

        public CChofer(string nombre,string apellido, string codigo, uint numero_de_Licencia, string distrito):base(nombre,apellido)
        {
            this.codigo = codigo;
            this.numero_de_Licencia = numero_de_Licencia;
            this.distrito = distrito;
        }



        public override string ToString()
        {
            return base.ToString() +"\n Codigo :"+ this.codigo +"\n N° de Licencia :"+ this.numero_de_Licencia +"\n Distrito :" + this.distrito;
        }
    }
}
