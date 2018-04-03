using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursal
    {
        List<vehiculos> vehiculos = new List<vehiculos>;

        string direccion;
        string nombre;

        public Sucursal ( string nombre, string direccion)
        {
            direccion = direccion;
            nombre = nombre;
        }
           

        public void agregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

    }



}
