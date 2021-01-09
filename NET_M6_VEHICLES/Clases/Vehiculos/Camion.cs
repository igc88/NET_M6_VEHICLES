using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NET_M6.Utilidades.Consola;

namespace NET_M6 {
    public class Camion: Vehiculo {
        public Camion(string matricula, string marca, string color) : base(matricula, marca, color, 2, 4, 'C')
        {
        }

        public static Camion CrearCamion()
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
                    camion.AñadirRuedas();

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
