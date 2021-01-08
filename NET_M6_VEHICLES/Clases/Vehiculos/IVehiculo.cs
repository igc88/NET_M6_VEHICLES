using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    public interface IVehiculo
    {
        string Matricula { get; set; }
        string Marca { get; set; }
        string Color { get; set; }
        int NumRuedas { get; set; }
        //IEnumerable<IRueda> Ruedas { get; set; }

        IEnumerable<IRueda> RuedasDelanteras { get; set; }
        IEnumerable<IRueda> RuedasTraseras { get; set; }

        bool ComprobarMatricula();
    }

}
