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
        CVehiculo vehiculo;
        bool esApto;

        public CConformacion(DateOnly fecha, CChofer chofer, ArrayList listaDeIntergrantes,CVehiculo vehiculo)
        {
            this.fecha = fecha;
            this.chofer = chofer;
            this.listaDeIntergrantes = listaDeIntergrantes;
            this.vehiculo = vehiculo;
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
        
        public bool AgregarUnIntergrante(CPersona persona)
        {
            listaDeIntergrantes.Add(persona);
            return true;
        }

        public CPersona BucarIntegrante(string legajo)
        {
            foreach(CPersona persona in listaDeIntergrantes)
            {
                if(persona.getLegajo() == legajo)
                {
                    return persona;
                }

            }
            return null;
        }
        public bool SacarUnIntergrante(CPersona persona)
        {
            listaDeIntergrantes.Remove(persona);
            return true;
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
