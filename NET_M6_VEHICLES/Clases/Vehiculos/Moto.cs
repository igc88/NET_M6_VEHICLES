using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NET_M6.Utilidades.Consola;

namespace NET_M6 {
    public class Moto : Vehiculo
    {
        public Moto(string matricula, string marca, string color) : base(matricula, marca, color, 2)
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

                    construye = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return moto;
        }

        public static void AñadirRuedasDelanteras(Moto m)
        {
            int ruedas = 1;
            int contador = 0;
            Rueda r = null;
            while (contador < ruedas)
            {
                try
                {
                    var marca = PedirString("Introduce la marca de rueda");
                    var diametro = PedirDouble("Introduce el diametro");
                    r = new Rueda(marca, diametro);
                    m.RuedasDelanteras.Append(r);
                    contador++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var item in m.RuedasDelanteras)
            {
                Console.WriteLine(item);
            }
        }

        public static void AñadirRuedasTraseras(Moto m)
        {
            int ruedas = 1;
            int contador = 0;
            Rueda r = null;
            while (contador < ruedas)
            {
                try
                {
                    var marca = PedirString("Introduce la marca de rueda");
                    var diametro = PedirDouble("Introduce el diametro");
                    r = new Rueda(marca, diametro);
                    m.RuedasTraseras.Append(r);
                    foreach (var item in m.RuedasTraseras)
                    {
                        Console.WriteLine(item);
                    }
                    contador++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
