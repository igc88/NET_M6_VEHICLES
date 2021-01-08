using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Coche : Vehiculo {
        // ATRIBUTOS
        public int NumRuedasDelanteras = 2 ;
        public int NumRuedasTraseras = 2;

        public Coche(string matricula, string marca, string color) {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }
    }
}
