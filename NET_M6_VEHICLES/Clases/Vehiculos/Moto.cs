using System;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    public class Moto : Vehiculo
    {
        private const char LicenciaNecesaria = 'A';
        public Moto(string matricula, string marca, string color) : base(matricula, marca, color, 1, 1, LicenciaNecesaria)
        {
        }

        public static Moto CrearMoto(Titular titular)
        {
            bool construye = false;
            Moto moto = null;
            while (!construye)
            {
                try
                {
                    var matricula = PedirString("Introduce la matricula");
                    var marca = PedirString("Introduce la marca");
                    var color = PedirString("Introduce el color");

                    moto = new Moto(matricula, marca, color);
                    if (PedirSiNo("Quieres que el titular sea también el conductor?"))
                    {
                        moto.Conductor = titular;
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
            return moto;
        }
    }
}
