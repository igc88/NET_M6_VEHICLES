using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Program {
        static void Main(string[] args) 
        {
            Console.WriteLine("Introduce la matricula del coche: ");
            string matricula = Console.ReadLine();
            Console.WriteLine("Introduce la marca del coche: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduce el color del coche: ");
            string color = Console.ReadLine();

            Coche coche = new Coche();
            Moto moto = new Moto();
        }
    }
}
