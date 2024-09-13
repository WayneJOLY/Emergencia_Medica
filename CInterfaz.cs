using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emergencia_Medica
{
    public class CInterfaz
    {
        static CInterfaz()
        {
           Console.BackgroundColor=ConsoleColor.Black;
        Console.ForegroundColor=ConsoleColor.Cyan;
        }


        public string MostrarInfo()
        {
            Console.WriteLine("[1] Registrar un empleado");
            Console.WriteLine("[2] Listar todos los empleados de la empresa, ordenados por legajo");
            Console.WriteLine("[3] Registrar un vehículo, que puede ser auto o ambulancia.\n");
            Console.WriteLine("[4] Registrar una conformación de dotación, indicando fecha, patente del vehículo asignado, legajo del chofer\n\ny legajo de todos los profesionales que integran la dotación.");
            Console.WriteLine("\n\n[5] Eliminar un empleado (chofer o profesional). Esto se debe poder hacer sólo si el empleado no integra\r\nninguna dotación.");
            Console.WriteLine("\n\n[6] Dado un legajo, informar los datos completos, si se trata de un chofer o un profesional y, además, todas\r\nlas fechas de sus asignaciones con los datos completos del vehículo asignado.");

            return PedirDato("LA Opcion Elegida :");
        }
            
        public string PedirDato(string ingreso) {

            string dato;
            Console.WriteLine($"Ingrese {ingreso}");
            dato=Console.ReadLine();

            while( dato == null)
            {
                Console.WriteLine($"Ingrese {ingreso}   \n Es OBLIGATORIO !");
                dato = Console.ReadLine();
            }

            return dato;
        }
    }
}
