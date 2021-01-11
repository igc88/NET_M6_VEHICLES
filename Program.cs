using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    class Program {
        static void Main(string[] args) 
        {
            int opcion = 0;
            string matricula = string.Empty;
            string marca = string.Empty;
            string color = string.Empty; 

            Console.WriteLine("Menu:\n 1-Coche \n 2-Moto \n 3-Camion");
            opcion = int.Parse(Console.ReadLine());
            
            switch (opcion) {
                case 1:                   
                    Coche coche = new Coche();
                    coche.anadirRuedas();

                    break;
                case 2:
                    Moto moto = new Moto();

                    break;
                case 3:
                    
                    break;
            }           

            

            

                     

            

            Console.ReadKey();
        }
    }
}
