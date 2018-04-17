using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            Auto auto = new Auto ("Mercedez", 5000, "BB-BB-11", "B");
            Moto moto = new Moto("BMW", 800, "BB-11", "C");
            Camion camion = new Camion("Mercedez", 5000, "BB-BB-11", "A2");
            Bus bus = new Bus("Mercedez", 5000, "BB-BB-11", "A1");

            vehiculos.Add(auto);
            vehiculos.Add(moto);
            vehiculos.Add(camion);
            vehiculos.Add(bus);

            Persona usuario = new Persona("Francisco", "19.890.210.2", "B");

            while (true)
            {
                string salir = "no";

                Console.WriteLine("Buenos Dias! /n Usted viene por parte de una Empresa o una Persona Natural? /n 1 = Empresa /n 2 = Persona /n 3 = Salir");
                string tipoUsuario = Console.ReadLine();

                while (tipoUsuario == "1" || tipoUsuario == "2") {
                    Console.WriteLine("Buenos Dias! /n ¿Que Operacion desea relizar? /n 1 = Arrendar Vehiculo /n 2 = Recibir un Vehiculo /n 3 = Salir");
                    string resp = Console.ReadLine();

                    while (resp == "1")
                    {
                        Console.WriteLine("Que tipo de Vehiculo desea arrendar? /n 1 = Auto /n 2 = Bus /n 3 = Camion /n 4 = Moto /n 5 = Acuatico /n 6 = Maquinaria Pesada");
                        string tipo = Console.ReadLine();
                        if (tipo == "1")
                        {
                            foreach (Vehiculo veh in vehiculos)
                            {
                                if (veh == auto)
                                {
                                    bool tof = veh.VerificacionCliente(usuario, veh);
                                    if (tof == true)
                                    {
                                        Console.WriteLine("Se ha registrado con exito su arriendo, auto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Tiene el permiso requerido para arrendar este Vehiculo");
                                        break;
                                    }
                                }
                            }
                        }
                        if (tipo == "2")
                        {
                            foreach (Vehiculo veh in vehiculos)
                            {
                                if (veh == bus)
                                {
                                    bool tof = veh.VerificacionCliente(usuario, veh);
                                    if (tof == true)
                                    {
                                        Console.WriteLine("Se ha registrado con exito su arriendo, bus");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Tiene el permiso requerido para arrendar este Vehiculo");
                                        break;
                                    }
                                }
                            }
                        }
                        if (tipo == "3")
                        {
                            foreach (Vehiculo veh in vehiculos)
                            {
                                if (veh == camion)
                                {
                                    bool tof = veh.VerificacionCliente(usuario, veh);
                                    if (tof == true)
                                    {
                                        Console.WriteLine("Se ha registrado con exito su arriendo, camion");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Tiene el permiso requerido para arrendar este Vehiculo");
                                        break;
                                    }
                                }
                            }
                        }
                        if (tipo == "4")
                        {
                            foreach (Vehiculo veh in vehiculos)
                            {
                                if (veh == moto)
                                {
                                    bool tof = veh.VerificacionCliente(usuario, veh);
                                    if (tof == true)
                                    {
                                        Console.WriteLine("Se ha registrado con exito su arriendo, moto");
                                    }
                                    else
                                    {
                                        Console.WriteLine("No Tiene el permiso requerido para arrendar este Vehiculo");
                                        break;
                                    }
                                }
                            }
                        }

                    }
                    while (resp == "2")
                    {

                    }
                    while (resp == "3")
                    {
                        Console.WriteLine("Adios! /n Desea Realizar otra operacion? /n 1 = Si /n 2 = No");
                        string salirResp = Console.ReadLine();
                        if (salirResp == "1")
                        {
                            break;
                        }
                        else if (salirResp == "2")
                        {
                            salir = "si";
                            break;
                        }
                        else
                        {

                        }
                    }
                    if (resp != "1" || resp != "2" || resp != "3")
                    {
                        Console.WriteLine("Respuesta Invalida, intente de nuevo");
                        continue;
                    }
                }
                if (tipoUsuario == "3" || salir == "si")
                {
                    break;
                }
                else if (tipoUsuario != "1" || tipoUsuario != "2" || tipoUsuario != "3")
                {
                    Console.WriteLine("Respuesta Invalida, intente de nuevo");
                    continue;
                }
            }
        }
    }
}
