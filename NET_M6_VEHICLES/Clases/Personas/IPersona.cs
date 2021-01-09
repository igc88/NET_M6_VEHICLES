using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    public interface IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public Licencia LicenciaConducir { get; set; }

    }
}
