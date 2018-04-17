using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Registro 
    {
        string cliente;
        Vehiculo vehiculo;
        string sucursal;
        string accesorios;
        DateTime inicio;
        DateTime termino;
        int valorServicio;

        public Registro(string cliente, Vehiculo vehiculo, string sucursal, string accesorios, DateTime inicio, DateTime termino, int valorServicio)
        {
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.sucursal = sucursal;
            this.accesorios = accesorios;
            this.inicio = inicio;
            this.termino = termino;
            this.valorServicio = valorServicio;
        }

    }
}
