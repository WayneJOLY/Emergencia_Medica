using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    public class CConformacion
    {
        DateOnly fecha;
        CChofer chofer;
        ArrayList listaDeIntergrantes;
        bool esApto;

        CConformacion(DateOnly fecha, CChofer chofer, ArrayList listaDeIntergrantes)
        {
            this.fecha = fecha;
            this.chofer = chofer;
            this.listaDeIntergrantes = listaDeIntergrantes;
        }

        public bool AgregarIntegrante(CPersona persona)
        {
            listaDeIntergrantes.Add(persona);
            return true;
        }
        
       
        public bool getEsApto()
        {
            return esApto;
        }

        public void setEsApto(bool esApto)
        {
            this.esApto = esApto;
        } 
        
        public override string ToString()
        {
            string datos = "";

            foreach(CPersona persona in listaDeIntergrantes)
            {
                datos += persona.ToString();
            }

            return "\n Fecha :" +fecha.ToString() +"\n Chofer :" + this.chofer.ToString() + "\n Lista de Integrantes :" + datos;
        }

    }
}
