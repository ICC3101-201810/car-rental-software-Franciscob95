using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Vehiculo

    {
        public string marca;
        public int motor;
        public string patente;
        protected Cliente cliente;

        public Vehiculo(string marca, int motor, string patente)
        {
            this.marca = marca;
            this.motor = motor;
            this.patente = patente;
        }
        public bool Verificacion(Cliente cliente)
        {
            if (cliente.GetType() == typeof(Persona))
            {

            }
        }
    }
}
