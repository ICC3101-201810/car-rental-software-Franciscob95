using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Registro : Vehiculo
    {
        string cliente;
        Vehiculo vehiculo;
        string sucursal;
        string accesorios;
        DateTime inicio;
        DateTime termino;
        int valorServicio;

        public Arriendo(string cliente, Vehiculo vehiculo, string sucursal, string accesorios, DateTime inicio, DateTime termino, int valorServivio)
        {
            cliente = cliente;
            vehiculo = vehiculo;
            sucursal = sucursal;
            accesorios = accesorios;
            inicio = inicio;
            termino = termino;
            valorServicio = valorServicio;
        }
    }
}
