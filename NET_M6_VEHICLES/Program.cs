using System;
using System.Collections.Generic;

namespace NET_M6
{
    class Program
    {
        static void Main(string[] args)
        {
            var salir = false;
            var arrPersonas = new List<IPersona>();
            var arrVehiculos = new List<IVehiculo>();

            Licencia licencia = new Licencia(1, 'B', "Weixin Xu", "1-1-2027");
            Titular usuario = new Titular("Weixin", "Xu", "1-1-1996", licencia, true, false);
            arrPersonas.Add(usuario);

            var menuPrincipal = new EasyConsole.Menu()
                .Add("Vehiculos", () =>
                {
                    var atras = false;
                    var menuVehiculos = new EasyConsole.Menu()
                        .Add("Coche", () =>
                        {
                            Coche c = Coche.CrearCoche(arrPersonas);
                            arrVehiculos.Add(c);
                        })
                        .Add("Moto", () =>
                        {
                            Moto m = Moto.CrearMoto(arrPersonas);
                            arrVehiculos.Add(m);
                        })
                        .Add("Camion", () =>
                        {
                            Camion c = Camion.CrearCamion(arrPersonas);
                            arrVehiculos.Add(c);
                        })
                        .Add("Atrás", () =>
                        {
                            foreach (var i in arrPersonas)
                            {
                                Console.WriteLine("----------Personas----------");
                                Console.WriteLine(i.ToString());
                            }
                            foreach (var i in arrVehiculos)
                            {
                                Console.WriteLine("----------Vehiculos----------");
                                Console.WriteLine(i.ToString());
                            }
                            atras = true;
                        });
                    while (!atras)
                    {
                        menuVehiculos.Display();
                    }
                })
                .Add("Personas", () =>
                {
                    var atras = false;
                    var menuVehiculos = new EasyConsole.Menu()
                        .Add("Titular", () =>
                        {
                            var t = Titular.CreaConductor();
                            arrPersonas.Add(t);
                        })
                        .Add("Conductor", () =>
                        {
                            var c = Conductor.CreaConductor();
                            arrPersonas.Add(c);
                        })
                        .Add("Atrás", () =>
                        {
                            foreach (var i in arrPersonas)
                            {
                                Console.WriteLine("----------Personas----------");
                                Console.WriteLine(i.ToString());
                            }
                            foreach (var i in arrVehiculos)
                            {
                                Console.WriteLine("----------Vehiculos----------");
                                Console.WriteLine(i.ToString());
                            }
                            atras = true;
                        });
                    while (!atras)
                    {
                        menuVehiculos.Display();
                    }
                })
                .Add("Salir", () =>
                {
                    salir = true;
                });
            while (!salir)
            {
                menuPrincipal.Display();
            }

        }   
    }
}
