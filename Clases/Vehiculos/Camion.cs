using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Camion : Vehiculo {
        public Camion() {
            while (!comprobarMatricula(this.matricula)) {
                Console.WriteLine("Introduce la matricula del camion: ");
                this.matricula = Console.ReadLine();
            }

            Console.WriteLine("Introduce la marca del camion: ");
            this.marca = Console.ReadLine();
            Console.WriteLine("Introduce el color del camion: ");
            this.color = Console.ReadLine();

            this.NumRuedasDelanteras = 2;
            this.NumRuedasTraseras = 2;
        }
    }
}
