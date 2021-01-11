using System;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    public class Titular : Conductor
    {
        public bool Seguro { get; set; }
        public bool Garaje { get; set; }

        public Titular(string nombre, string apellido, string fechaNacimiento, Licencia licenciaConducir, bool seguro, bool garaje) : base(nombre,apellido,fechaNacimiento,licenciaConducir)
        {
            Seguro = seguro;
            Garaje = garaje;
        }

        public override string ToString()
        {
            return base.ToString() + " Titular: Sí";
        }

        public static Titular CreaTitular()
        {
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

            var seguro = PedirSiNo("Tiene seguro?");
            var garaje = PedirSiNo("Tiene garaje?");

            return new Titular(nombre, apellido, fechaNacimiento, lic, seguro, garaje);
        }

    }
}
