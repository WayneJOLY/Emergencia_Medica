using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    public class CVehiculo
    {
        private string patente;
        private string marca;
        private string modelo;

        public CVehiculo(string patente, string marca, string modelo)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
        }

        public string getPatente()
        {
            return patente;
        }

        public override string ToString()
        {
            return "\n Patente :"+ this.patente + "\n Marca :"+ this.marca +"\n Modelo :"+ this.modelo;
        }
    }
}
