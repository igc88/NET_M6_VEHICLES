using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Moto:Vehiculo 
    {
        public Moto() {
            while (!comprobarMatricula(this.matricula)) {
                Console.WriteLine("Introduce la matricula de la moto: ");
                this.matricula = Console.ReadLine();
            }

            Console.WriteLine("Introduce la marca la moto: ");
            this.marca = Console.ReadLine();
            Console.WriteLine("Introduce el color la moto: ");
            this.color = Console.ReadLine();

            this.NumRuedasDelanteras = 1;
            this.NumRuedasTraseras = 1;
        }
    }
}
