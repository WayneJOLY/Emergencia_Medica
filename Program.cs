namespace Emergencia_Medica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // INICIO VARIABLES
            sbyte opcion;
            string nombre, apellido, distrito, codigo, patente, marca, modelo;
            uint licencia, tipoDeProfecional, matricula, tipoDeAmbulancia;
            char tipoDePersona, tipoDeVehiculo;

            CChofer chofer;
            CiProfecionales profecionale;
            CAmbulancia ambulancia;
            CAuto auto;

            List<CChofer> listaDeChoferes = new List<CChofer>();
            List<CiProfecionales> listaDeProfecionales = new List<CiProfecionales>();
            List<CAuto> listaDeAutos = new List<CAuto>();
            List<CAmbulancia> listaDeAmbulancia = new List<CAmbulancia>();


            //CATEGORIA_PROFECIONAL cat;
            CInterfaz interfaz = new CInterfaz();
            // INICIO VARIABLES

            Console.WriteLine("Hello, World!");





            do
            {

                opcion = sbyte.Parse(interfaz.MostrarInfo());



                switch (opcion)
                {


                    case 1:
                        nombre = interfaz.PedirDato("Nombre");
                        apellido = interfaz.PedirDato("Apellido");
                        codigo = interfaz.PedirDato("Codigo");


                        tipoDePersona = char.Parse(interfaz.PedirDato("El tipo De Persona :\n [A] -> Chofer \n [B] -> Profecional de Salud"));

                        tipoDePersona = char.ToUpper(tipoDePersona);//Converción a majuscula del caracter
                        switch (tipoDePersona)
                        {
                            case 'A':
                                licencia = uint.Parse(interfaz.PedirDato(" El Numero de la Licencia"));
                                distrito = interfaz.PedirDato(" El distrito");

                                chofer = new CChofer(nombre, apellido, codigo, licencia, distrito);

                                listaDeChoferes.Add(chofer);

                                break;


                            case 'B':

                                tipoDeProfecional = uint.Parse(interfaz.PedirDato(" El Tipo de Profecional \n [1] Medico \n [2] Enfermero \n [3] ParaMedico"));
                                matricula = uint.Parse(interfaz.PedirDato("El Numero de Matricula del Profcional"));

                                profecionale = new CiProfecionales(nombre, apellido, codigo, matricula, tipoDeProfecional);
                                listaDeProfecionales.Add(profecionale);
                                break;
                        }


                        break;
                    case 2:

                        foreach (CChofer ch in listaDeChoferes)
                        {
                            Console.WriteLine(ch.ToString());
                        }

                        foreach (CiProfecionales profecional in listaDeProfecionales)
                        {
                            Console.WriteLine(profecional.ToString());
                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        marca = interfaz.PedirDato("La Marca");
                        modelo = interfaz.PedirDato("El Modelo");
                        patente = interfaz.PedirDato("La Patente");

                        tipoDeVehiculo = char.Parse(interfaz.PedirDato("El tipo de Vehiculo a Registrar \n [A] Auto \n [B] Ambulancia "));
                        tipoDeVehiculo = char.ToUpper(tipoDeVehiculo);//Converción a majuscula del caracter
                        switch (tipoDeVehiculo)
                        {

                            case 'A':
                                auto = new CAuto(patente, marca, modelo);
                                listaDeAutos.Add(auto);
                                break;


                            case 'B':
                                tipoDeAmbulancia = uint.Parse(interfaz.PedirDato("El tipo de Ambulancia \n [1] emergencia \n[2] terapia_intensiva_móvil \n [3]  unidad_coronaria_móvil"));

                                if(tipoDeAmbulancia>0 &&  tipoDeAmbulancia< 4)
                                {
                                    ambulancia = new CAmbulancia(patente, marca, modelo, tipoDeAmbulancia);
                                    listaDeAmbulancia.Add(ambulancia);
                                }
                                break;
                        }
                        break;
                    case 4:

                        break;
                }



            } while (opcion != 0);



            CiProfecionales BucarProfecional(uint legajo)
            {
                foreach (CiProfecionales profecional in listaDeProfecionales)
                {
                    if (profecional.geCodigo() == legajo)
                    {
                        return profecional;
                    }
                }

                return null;
            }

            CChofer BuscarChofer(string legajo)
            {
                foreach (CChofer ch in listaDeChoferes)
                {
                    if (ch.getCodigo() == legajo)
                    {
                        return ch;
                    }
                }

                return null ;
            }
        }


    }
}
