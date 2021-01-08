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

            Coche coche = new Coche(matricula, marca, color);
            //Moto moto = new Moto();
            Console.WriteLine("Introduce la marca de la rueda: ");
            string marcaRueda = Console.ReadLine();

            Console.WriteLine("Introduce el diametro de la rueda: ");
            double diametro = double.Parse(Console.ReadLine());

            for (int i = 0; i < coche.NumRuedasDelanteras; i++) {
                coche.ruedasDelanteras.Add(new Rueda(marcaRueda, diametro));
            }

            for (int i = 0; i < coche.NumRuedasTraseras; i++) {
                coche.ruedasDelanteras.Add(new Rueda(marcaRueda, diametro));
            }

            if (coche.comprobarMatricula(coche.matricula)) {
                Console.WriteLine("La matricula es correcta.");
            }

            Console.ReadKey();
        }
    }
}
