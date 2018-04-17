using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Moto : Vehiculo
    {
        public Moto(string marca, int motor, string patente, string permiso) : base ( marca, motor, patente, permiso)
        {
            this.marca = marca;
            this.motor = motor;
            this.patente = patente;
            this.permiso = permiso;
        }
    }
}
