using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Rueda
    {
        // ATRIBUTOS
        public string marcaRueda;
        public double diametro;
        // CONSTRUCTORES
        public Rueda(string marcaRueda, double diametro) 
        {
            this.marcaRueda = marcaRueda;
            this.diametro = diametro;
        }
        // METODOS
        public bool comprobarDiametro(double diametro)
        {
            if ((diametro<0.4) && (diametro>4.0))  { return false; } 
            return true;
        }
    }
}
