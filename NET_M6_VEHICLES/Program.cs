using System;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    class Program
    {
        static void Main(string[] args)
        {
            var salir = false;
            Licencia licencia = new Licencia(1, 'B', "Weixin Xu", "1-1-2027");
            Titular usuario = new Titular("Weixin", "Xu", "11-11-1996", licencia, true, false);

            var menu = new EasyConsole.Menu()
                .Add("Coche", () => {
                    Coche c = Coche.CrearCoche(usuario);
                })
                .Add("Moto", () => {
                    Moto m = Moto.CrearMoto();
                })
                .Add("Camion", ()=> {
                    Camion c = Camion.CrearCamion();
                })
                .Add("Salir", () => salir = true);
            while (!salir) {
                menu.Display();
            }
                
            
        }   
    }
}
