using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
   public  enum CategoriaProfecional
    {
        medico,
        enfermero,
        paramedico
    }
    public class CiProfecionales:CPersona
    {
        uint matricula;
        string codigo;
        private CategoriaProfecional categoriaProfecional;

        public CiProfecionales(string nombre, string apellido,string legajo,uint matricula, uint cATEGOTIA_PROFECIONAL):base(nombre,apellido,legajo)
        {
            this.matricula = matricula;
            this.codigo = codigo;
            categoriaProfecional = (CategoriaProfecional)cATEGOTIA_PROFECIONAL;
        }


        public override string ToString()
        {
            return base.ToString() + "\n Matricula :"+ this.matricula + "\n Codigo :"+ this.codigo +"\n Categoria Profecional :"+ this.categoriaProfecional.ToString();
        }

        //public string geCodigo() { return this.codigo; }
    }
}
