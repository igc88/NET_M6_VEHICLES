using System;
using System.Collections.Generic;
using System.Linq;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    public class Moto : Vehiculo
    {
        private const char LicenciaNecesaria = 'A';
        public Moto(string matricula, string marca, string color) : base(matricula, marca, color, 1, 1, LicenciaNecesaria)
        {
        }

        public static Moto CrearMoto(IEnumerable<IPersona> personas)
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
                    moto.Titular = titulares.ElementAt(seleccionado - 1);
                    if (PedirSiNo("Quieres que el titular sea también el conductor?"))
                    {
                        moto.Conductor = moto.Titular;
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
                        moto.Conductor = conductores.ElementAt(conductorSeleccionado - 1);
                        if (moto.Conductor.LicenciaConducir.TiposLicencia != LicenciaNecesaria)
                            throw new Exception("No tienes la licencia adecuada.");
                    }

                    construye = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }
            }
            return moto;
        }
    }
}
