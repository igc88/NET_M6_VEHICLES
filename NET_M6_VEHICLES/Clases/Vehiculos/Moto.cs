using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NET_M6.Utilidades.Consola;

namespace NET_M6 {
    public class Moto : Vehiculo
    {
        public Moto(string matricula, string marca, string color) : base(matricula, marca, color, 1, 1, 'A')
        {
        }

        public static Moto CrearMoto()
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
                    moto.AñadirRuedas();

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
