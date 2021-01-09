using System;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    public class Camion: Vehiculo {
        private const char LicenciaNecesaria = 'C';
        public Camion(string matricula, string marca, string color) : base(matricula, marca, color, 2, 4, LicenciaNecesaria)
        {
        }

        public static Camion CrearCamion(Titular titular)
        {
            bool construye = false;
            Camion camion = null;
            while (!construye)
            {
                try
                {
                    var matricula = PedirString("Introduce la matricula");
                    var marca = PedirString("Introduce la marca");
                    var color = PedirString("Introduce el color");

                    camion = new Camion(matricula, marca, color);
                    camion.Titular = titular;
                    if (PedirSiNo("Quieres que el titular sea también el conductor?"))
                    {
                        camion.Conductor = titular;
                    }
                    else
                    {
                        Conductor c = Conductor.CreaConductor();
                        if (c.LicenciaConducir.TiposLicencia != LicenciaNecesaria)
                            throw new ArgumentException("No tienes la licencia adecuada.", nameof(c));
                    }

                    construye = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return camion;
        }
    }
}
