using System;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    class Program
    {
        static void Main(string[] args)
        {
            var salir = false;
            var menu = new EasyConsole.Menu()
                .Add("Coche", () => {
                    Coche c = Coche.CrearCoche();
                    Coche.AñadirRuedasDelanteras(c);
                    Coche.AñadirRuedasTraseras(c);
                })
                .Add("Moto", () => {
                    Moto m = Moto.CrearMoto();
                    Moto.AñadirRuedasDelanteras(m);
                    Moto.AñadirRuedasTraseras(m);
                })
                .Add("Salir", () => salir = true);
            while (!salir)
                menu.Display();
            
        }   
    }
}
