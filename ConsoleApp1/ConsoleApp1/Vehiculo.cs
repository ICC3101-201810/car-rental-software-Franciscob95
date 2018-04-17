using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehiculo

    {
        public string marca;
        public int motor;
        public string patente;
        public string permiso;
        protected Cliente cliente;

        public Vehiculo(string marca, int motor, string patente, string permiso)
        {
            this.marca = marca;
            this.motor = motor;
            this.patente = patente;
            this.permiso = permiso;
        }
        public string GetPermiso()
        {
            return permiso;
        }
        public bool VerificacionCliente(Persona persona, Vehiculo vehiculo)
        {
            if (persona.GetLicencia() == vehiculo.GetPermiso())
            {
                return true;
            }
            return false;
        }
        public bool VerificacionEmpresa(Empresa empresa)
        {
            if (empresa.GetAutorizacion() == true)
            {
                return true;
            }
            return false;
        }
    }
}
