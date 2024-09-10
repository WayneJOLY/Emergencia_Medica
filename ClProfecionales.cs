using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    enum CATEGOTIA_PROFECIONAL
    {
        medico,
        enfermero,
        paramedico
    }
    internal class CiProfecionales:CPersona
    {
        string matricula;
        uint codigo;
        Enum CATEGOTIA_PROFECIONAL ;

        public CiProfecionales(string nombre, string apellido,string matricula, uint codigo, Enum cATEGOTIA_PROFECIONAL):base(nombre,apellido)
        {
            this.matricula = matricula;
            this.codigo = codigo;
            CATEGOTIA_PROFECIONAL = cATEGOTIA_PROFECIONAL;
        }


        public override string ToString()
        {
            return base.ToString() + "\n Matricula :"+ this.matricula + "\n Codigo :"+ this.codigo +"\n Categoria Profecional :"+ this.CATEGOTIA_PROFECIONAL.ToString();
        }
    }
}
