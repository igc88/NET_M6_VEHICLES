using System;
using System.Collections.Generic;

namespace NET_M6
{
    class Program
    {
        static void Main(string[] args)
        {
            var salir = false;
            List<IPersona> arrPersonas = new List<IPersona>();
            var arrVehiculos = new List<IVehiculo>();

            Licencia licencia = new Licencia(1, 'B', "Weixin Xu", "1-1-2027");
            Titular usuario = new Titular("Weixin", "Xu", "11-11-1996", licencia, true, false);

            var menu = new EasyConsole.Menu()
                .Add("Coche", () =>
                {
                    Coche c = Coche.CrearCoche(usuario);
                    arrPersonas.Add(usuario);
                    arrVehiculos.Add(c);
                })
                .Add("Moto", () =>
                {
                    Moto m = Moto.CrearMoto(usuario);
                    arrPersonas.Add(usuario);
                    arrVehiculos.Add(m);
                })
                .Add("Camion", () =>
                {
                    Camion c = Camion.CrearCamion(usuario);
                    arrPersonas.Add(usuario);
                    arrVehiculos.Add(c);
                })
                .Add("Salir", () =>
                {
                    foreach (var i in arrPersonas)
                    {
                        Console.WriteLine("----------");
                        Console.WriteLine(i);
                    }
                    foreach (var i in arrVehiculos)
                    {
                        Console.WriteLine("----------");
                        Console.WriteLine(i);
                    }
                    salir = true;
                });
            while (!salir) {
                menu.Display();
            }
                
        }   
    }
}
