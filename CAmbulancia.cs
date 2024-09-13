using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    public enum TipoDeAmbulancia
    {
        emergencia ,
        terapia_intensiva_móvil,
        unidad_coronaria_móvil,
    }
    internal class CAmbulancia:CVehiculo
    {
        private TipoDeAmbulancia tipoDeAmbulancia;

        public CAmbulancia(string patente, string marca, string modelo,uint tipoAmbulancia) : base(patente, marca, modelo)
        {
            this.tipoDeAmbulancia = (TipoDeAmbulancia)tipoAmbulancia;
        }

        public override string ToString()
        {
            return base.ToString()+ "\n Tipo de Ambulancia :" +this.tipoDeAmbulancia.ToString();

        }
    }
}
