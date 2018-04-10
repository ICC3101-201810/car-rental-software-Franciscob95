using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Empresa : Cliente
    {
        bool autorizacion;

        public Empresa(string nombre, string RUT, bool autorizacion) : base(nombre, RUT)
        {
            this.nombre = nombre;
            this.RUT = RUT;
            this.autorizacion = autorizacion;

        }
    }
}
