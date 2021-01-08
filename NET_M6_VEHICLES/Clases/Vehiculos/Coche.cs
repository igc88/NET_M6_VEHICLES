using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NET_M6.Utilidades.Consola;

namespace NET_M6 {
    public class Coche : Vehiculo
    {
        public Coche(string matricula, string marca, string color): base(matricula, marca, color, 4)
        {

        }

        public static Coche CrearCoche()
        {
            bool construye = false;
            Coche coche = null;
            while (!construye)
            {
                try
                {
                    var matricula = PedirString("Introduce la matricula");
                    var marca = PedirString("Introduce la marca");
                    var color = PedirString("Introduce el color");
                    coche = new Coche(matricula, marca, color);
                    
                    construye = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            return coche;
        }

        public static void AñadirRuedasDelanteras(Coche c)
        {
            int ruedas = 2;
            int contador = 0;
            Rueda r = null;
            while (contador < ruedas)
            {
                try
                {
                    var marca = PedirString("Introduce la marca de rueda");
                    var diametro = PedirDouble("Introduce el diametro");
                    r = new Rueda(marca, diametro);
                    c.RuedasDelanteras.Append(r);
                    contador++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            foreach (var item in c.RuedasDelanteras)
            {
                Console.WriteLine(item);
            }
        }

        public static void AñadirRuedasTraseras(Coche c)
        {
            int ruedas = 2;
            int contador = 0;
            Rueda r = null;
            while (contador < ruedas)
            {
                try
                {
                    var marca = PedirString("Introduce la marca de rueda");
                    var diametro = PedirDouble("Introduce el diametro");
                    r = new Rueda(marca, diametro);
                    c.RuedasTraseras.Append(r);
                    foreach (var item in c.RuedasTraseras)
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
