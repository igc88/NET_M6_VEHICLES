using System;
using System.Collections.Generic;
using System.Linq;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    public class Camion: Vehiculo {
        private const char LicenciaNecesaria = 'C';
        public Camion(string matricula, string marca, string color) : base(matricula, marca, color, 2, 4, LicenciaNecesaria)
        {
        }

        public static Camion CrearCamion(IEnumerable<IPersona> personas)
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
                    Console.WriteLine("Escoge un titular:");
                    var titulares = personas.Where(x => x is Titular).Select(x => x as Titular);
                    for (int i = 0; i < titulares.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}: {titulares.ElementAt(i).Nombre} {titulares.ElementAt(i).Apellido}");
                    }
                    int seleccionado = 0;
                    do
                    {
                        Console.WriteLine("Que titular quieres?");
                        try
                        {
                            seleccionado = int.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Introduce un número");
                        }
                    } while (seleccionado <= 0 || seleccionado > titulares.Count());
                    camion.Titular = titulares.ElementAt(seleccionado - 1);
                    if (PedirSiNo("Quieres que el titular sea también el conductor?"))
                    {
                        camion.Conductor = camion.Titular;
                    }
                    else
                    {
                        Console.WriteLine("Escoge un conductor:");
                        var conductores = personas.Where(x => x is Conductor).Select(x => x as Conductor);
                        for (int i = 0; i < conductores.Count(); i++)
                        {
                            Console.WriteLine($"{i + 1}: {conductores.ElementAt(i).Nombre} {conductores.ElementAt(i).Apellido}");
                        }
                        int conductorSeleccionado = 0;
                        do
                        {
                            Console.WriteLine("Que conductor quieres?");
                            try
                            {
                                conductorSeleccionado = int.Parse(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Introduce un número");
                            }
                        } while (conductorSeleccionado <= 0 || conductorSeleccionado > conductores.Count());
                        camion.Conductor = conductores.ElementAt(conductorSeleccionado - 1);
                        if (camion.Conductor.LicenciaConducir.TiposLicencia != LicenciaNecesaria)
                            throw new Exception("No tienes la licencia adecuada.");
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
