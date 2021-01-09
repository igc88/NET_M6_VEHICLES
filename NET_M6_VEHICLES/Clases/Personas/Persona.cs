using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    public class Persona : IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public Licencia LicenciaConducir { get; set; } 

        public Persona(string nombre, string apellido, string fechaNacimiento, Licencia licenciaConducir)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            LicenciaConducir = licenciaConducir;
        }
    }
}
