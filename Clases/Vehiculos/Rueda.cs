using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Rueda {
        private string marcaRueda = string.Empty;
        private double diametro = 0; 

        public Rueda(string marcaRueda, double diametro) {
            Console.WriteLine("Introduce la marca de la rueda: ");
            this.marcaRueda = Console.ReadLine();

            while (this.diametro <= 0.4 || this.diametro >= 4) {
                Console.WriteLine("Introduce el diametro de la rueda (: ");
                this.diametro = double.Parse(Console.ReadLine());
            }            
        }
    }
}