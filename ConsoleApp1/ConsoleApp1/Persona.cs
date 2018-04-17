using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Persona : Cliente
    {
        string TipoDeLicencia;
        public Persona(string nombre, string RUT, string TipoDeLicencia) : base (nombre, RUT)
        {
            this.nombre = nombre;
            this.RUT = RUT;
            this.TipoDeLicencia = TipoDeLicencia;
        }
        public string GetLicencia()
        {
            return TipoDeLicencia;
        }
    }
}
