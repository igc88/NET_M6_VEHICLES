using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NET_M6.Utilidades.Consola;

namespace NET_M6 {
    public class Coche : Vehiculo
    {
        private const char LicenciaNecesaria = 'B';
        public Coche(string matricula, string marca, string color): base(matricula, marca, color, 2, 2, LicenciaNecesaria)
        {
        }

        public static Coche CrearCoche(Titular titular)
        {
            bool construye = false;
            Coche coche = null;
            while (!construye)
            {
                if (titular.LicenciaConducir.TiposLicencia != LicenciaNecesaria)
                    throw new ArgumentException("No tienes la licencia adecuada.", nameof(titular));
                try
                {
                    var matricula = "1234HWT"; // PedirString("Introduce la matricula");
                    var marca = "Chery"; // PedirString("Introduce la marca");
                    var color = "Rojo"; // PedirString("Introduce el color");
                    
                    coche = new Coche(matricula, marca, color);
                    //coche.AñadirRuedas();
                    coche.Titular = titular;
                    if(PedirSiNo("Quieres que el titular sea también el conductor?"))
                    {
                        coche.Conductor = titular;
                    }
                    else
                    {
                        Console.WriteLine("Aun no está hecho");
                        Conductor c = Conductor.CreaConductor();
                        if (c.LicenciaConducir.TiposLicencia != LicenciaNecesaria)
                            throw new ArgumentException("No tienes la licencia adecuada.", nameof(c));
                    }
                    
                    construye = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return coche;
        }


    }
}
