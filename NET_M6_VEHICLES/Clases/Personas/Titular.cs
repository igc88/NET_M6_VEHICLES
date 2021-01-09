using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    public class Titular : Conductor
    {
        public bool Seguro { get; set; }
        public bool Garaje { get; set; }

        public Titular(string nombre, string apellido, string fechaNacimiento, Licencia licenciaConducir, bool seguro, bool garaje) : base(nombre,apellido,fechaNacimiento,licenciaConducir)
        {
            Seguro = seguro;
            Garaje = garaje;
        }
    }
}
