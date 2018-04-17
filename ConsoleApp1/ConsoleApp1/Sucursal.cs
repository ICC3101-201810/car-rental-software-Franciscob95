using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Sucursal
    {
        List<Vehiculo> vehiculos = new List<Vehiculo>();

        string direccion;
        string nombre;

        public Sucursal ( string nombre, string direccion)
        {
            this.direccion = direccion;
            this.nombre = nombre;
        }
           

        public void agregarVehiculo(Vehiculo vehiculo)
        {
            vehiculos.Add(vehiculo);
        }

    }



}
