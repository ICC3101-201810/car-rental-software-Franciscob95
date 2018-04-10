using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Cliente
    {
        protected string nombre;
        protected string RUT;
      
        public Cliente (string nombre, string RUT)
        {
            this.nombre = nombre;
            this.RUT = RUT;
        }

        public abstract int GetID();
    }
}
