﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    public class CChofer:CPersona
    {

        string codigo;
        uint numero_de_Licencia;
        string distrito;

        public CChofer(string nombre,string apellido, string legajo, uint numero_de_Licencia, string distrito):base(nombre,apellido,legajo)
        {
            //this.codigo = codigo;
            this.numero_de_Licencia = numero_de_Licencia;
            this.distrito = distrito;
        }


        //public string getCodigo()
        //{
        //    return codigo;
        //}
        public override string ToString()
        {
            return base.ToString() +"\n Codigo :"+ this.codigo +"\n N° de Licencia :"+ this.numero_de_Licencia +"\n Distrito :" + this.distrito;
        }
    }
}
