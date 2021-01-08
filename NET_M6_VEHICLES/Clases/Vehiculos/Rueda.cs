using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    public class Rueda : IRueda
    {
        public string Marca { get; set; }
        public double Diametro { get; set; }

        public Rueda(string marca, double diametro)
        {
            Marca = marca;
            Diametro = diametro;
            if (!ComprobarDiametro())
               throw new ArgumentOutOfRangeException(nameof(diametro), diametro, "debe ser superior a 0.4 e inferior a 4");
        }

        public bool ComprobarDiametro()
        {
            return Diametro > 0.4 && Diametro < 4;
        }
    }
}
