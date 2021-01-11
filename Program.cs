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

            Conductor conductor;

            Titular usuario = new Titular();

            Console.WriteLine("El titular sera el conductor del vehículo?");
            int usuarioVehiculo = int.Parse(Console.ReadLine());

            if (usuarioVehiculo == 1) {
                conductor = new Conductor(usuario);
            } else {
                conductor = new Conductor();
            }

            Console.WriteLine("Seleccione el vehiculo:\n 1-Coche \n 2-Moto \n 3-Camion");
            opcion = int.Parse(Console.ReadLine());
            
            switch (opcion) {
                case 1:
                    if (usuario.licencia.tipo == "C") {
                        Coche coche = new Coche();
                        coche.anadirRuedas();
                    } else {
                        Console.WriteLine("No tiene la licencia correcta.");
                    }

                    break;
                case 2:
                    if (usuario.licencia.tipo == "M") {
                        Moto moto = new Moto();
                        moto.anadirRuedas();
                    } else {
                        Console.WriteLine("No tiene la licencia correcta.");
                    }

                    break;
                case 3:
                    if (usuario.licencia.tipo == "T") {
                        Camion camion = new Camion();
                        camion.anadirRuedas();
                    } else {
                        Console.WriteLine("No tiene la licencia correcta.");
                    }                    

                    break;
            }           

            Console.ReadKey();
        }
    }
}
