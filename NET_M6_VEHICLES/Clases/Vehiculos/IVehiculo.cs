using System.Collections.Generic;

namespace NET_M6
{
    public interface IVehiculo
    {
        string Matricula { get; set; }
        string Marca { get; set; }
        string Color { get; set; }
        int NumRuedasDelanteras { get; set; }
        int NumRuedasTraseras { get; set; }
        IEnumerable<IRueda> RuedasDelanteras { get; set; }
        IEnumerable<IRueda> RuedasTraseras { get; set; }
        char TiposLicencia { get; set; }
        Titular Titular { get; set; }
        IEnumerable<IPersona> ListaPersonas { get; set; }
        bool ComprobarMatricula();

    }

}
