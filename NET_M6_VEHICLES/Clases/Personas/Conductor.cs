using System;
using System.Collections.Generic;
using static NET_M6.Utilidades.Consola;


namespace NET_M6
{
    public class Conductor : Persona
    {
        public Conductor(string nombre, string apellido, string fechaNacimiento, Licencia licenciaConducir): base(nombre, apellido,fechaNacimiento, licenciaConducir)
        {
        }

        public static Conductor CreaConductor()
        {
            Console.WriteLine("----------Crear un conductor nuevo----------");
            string nombre = PedirString("Introduce nombre");
            string apellido = PedirString("Introduce apellido");
            string fechaNacimiento = PedirString("Introduce fecha de nacimiento");

            Console.WriteLine("Indroduce id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce licencia de conducir: A / B / C");
            char licencia = Convert.ToChar(Console.ReadLine());
            string nombreCompleto = nombre + " " + apellido;
            string fechaCaducidad = PedirString("Introduce fecha de caducidad de licencia");

            Licencia lic = new Licencia(id, licencia, nombreCompleto, fechaCaducidad);

            return new Conductor(nombre, apellido, fechaNacimiento, lic);
        }

        public override string ToString()
        {
            return @$"Nombre: {Nombre} Apellido: {Apellido} ";
        }

    }
}
