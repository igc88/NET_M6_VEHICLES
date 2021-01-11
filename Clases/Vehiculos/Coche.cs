using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Coche : Vehiculo {
        public Coche() {
            while (!comprobarMatricula(this.matricula)) {
                Console.WriteLine("Introduce la matricula del coche: ");
                this.matricula = Console.ReadLine();
            }
            
            Console.WriteLine("Introduce la marca del coche: ");
            this.marca = Console.ReadLine();
            Console.WriteLine("Introduce el color del coche: ");
            this.color = Console.ReadLine();            

            this.NumRuedasDelanteras = 2;
            this.NumRuedasTraseras = 2;            
        }
    }
}
