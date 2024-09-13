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
        string matricula;
        uint codigo;
        private CategoriaProfecional categoriaProfecional;

        public CiProfecionales(string nombre, string apellido,string matricula, uint codigo, uint cATEGOTIA_PROFECIONAL):base(nombre,apellido)
        {
            this.matricula = matricula;
            this.codigo = codigo;
            this.categoriaProfecional = (CategoriaProfecional)cATEGOTIA_PROFECIONAL;
        }


        public override string ToString()
        {
            return base.ToString() + "\n Matricula :"+ this.matricula + "\n Codigo :"+ this.codigo +"\n Categoria Profecional :"+ this.categoriaProfecional.ToString();
        }

        
    }
}
