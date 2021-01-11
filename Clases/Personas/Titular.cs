using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Titular : Persona {
        public bool seguro;
        public bool garaje;

        public Titular() {
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

            Console.WriteLine("Tiene seguro?");
            string seguro = Console.ReadLine();
            this.seguro = (seguro == "1") ? true : false;

            Console.WriteLine("Tiene garaje?");
            string garaje = Console.ReadLine();
            this.garaje = (garaje == "1") ? true : false;

            this.licencia = new Licencia(this.nombre, this.apellidos, tipo, caducidad);
        }

        
    }
}
