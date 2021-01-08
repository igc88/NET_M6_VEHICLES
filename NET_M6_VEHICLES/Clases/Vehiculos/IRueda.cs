using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    public interface IRueda
    {
        string Marca { get; set; }
        double Diametro { get; set; }
        bool ComprobarDiametro();
    }
}
