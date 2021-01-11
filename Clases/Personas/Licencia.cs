using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Licencia {
        public string id = string.Empty;
        public string tipo = string.Empty;
        public string nombre = string.Empty;
        public string fechaCaducidad = string.Empty;

        public Licencia(string nombre, string apellidos, string tipo, string caducidad) {
            this.nombre = nombre + " " + apellidos;

            this.tipo = tipo;
            this.fechaCaducidad = caducidad;
        }
    }
}
