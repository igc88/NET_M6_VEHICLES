using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Conductor : Persona {
        public Conductor() {

            Console.WriteLine("Introduzca el nombre: ");
            this.nombre = Console.ReadLine();

            Console.WriteLine("Introduzca los apellidos: ");
            this.apellidos = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de nacimiento: ");
            this.fechaNacimiento = Console.ReadLine();

            Console.WriteLine("Introduzca los datos para la licencia");

            Console.WriteLine("Introduzca el tipo de licencia (C, M, T)");
            string tipo = Console.ReadLine();

            Console.WriteLine("Introduzca la fecha de caducidad: ");
            string caducidad = Console.ReadLine();

            this.licencia = new Licencia(this.nombre, this.apellidos, tipo, caducidad);
        }

        public Conductor (Titular usuario) {
            this.nombre = usuario.nombre;
            this.apellidos = usuario.apellidos;
            this.fechaNacimiento = usuario.fechaNacimiento;

            this.licencia = new Licencia(usuario.nombre, usuario.apellidos, usuario.licencia.tipo, usuario.licencia.fechaCaducidad);
        }
    }
}

