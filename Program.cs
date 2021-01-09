using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    class Program
    {
        static void Main(string[] args)
        {
            Titular titular = new Titular("Viksen", "Senkov", "15/12/1995", true, true, true);
            titular.datosTitular();
            Console.WriteLine("");

            while (titular.comprobarLicencia(titular.licenciaTitular) == false)
            { Console.WriteLine("No tiene licencia, saquesela antes."); }
            if (titular.comprobarLicencia(titular.licenciaTitular))
            { Console.WriteLine("Que tipo de licencia tiene?"); }
            Console.WriteLine("");

            Licencia licencia = new Licencia(1, 'A', "Licencia de coche", "20/05/2022");
            licencia.tipoLicencia();
            Console.WriteLine("");
            licencia.DatosLicen();
            Console.WriteLine("");

            Vehiculo vehiculo = new Vehiculo();
            int menu;
            Console.WriteLine("Que desea crear? \n1) Coche \n2) Moto \n3) Camion");

            menu = Convert.ToInt32(Console.ReadLine());
       
                switch (menu)
                {
                    case 1:
                    while (licencia.comprobarIDcoche(licencia.tipoLicen) == false)
                    { Console.WriteLine("Su licencia no es apta para coche"); }
                    if (licencia.comprobarIDcoche(licencia.tipoLicen) == true)  
                    { Console.WriteLine("Has seleccionado coche"); }
                        Console.WriteLine("");
                        vehiculo.coche();
                        break;
                    
                    case 2:
                        while (licencia.comprobarIDmoto(licencia.tipoLicen) == false)
                        { Console.WriteLine("Su licencia no es apta para moto"); }
                        if (licencia.comprobarIDmoto(licencia.tipoLicen) == true)
                        { Console.WriteLine("Has seleccionado moto"); }
                        Console.WriteLine("");
                        vehiculo.moto();
                        break;

                    case 3:
                        while (licencia.comprobarIDcamion(licencia.tipoLicen) == false)
                        { Console.WriteLine("Su licencia no es apta para camion"); }
                        if (licencia.comprobarIDcamion(licencia.tipoLicen) == true)
                        { Console.WriteLine("Has seleccionado camion"); }
                        Console.WriteLine("");
                        vehiculo.camion();
                        break;
                }
            Console.WriteLine("");

            Console.WriteLine("El titular sera tambien el conductor? \n1) Si \n2) No");
            int titCond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            if (titCond == 1)
            { Console.WriteLine("Gracias");
                Environment.Exit(1);
            }
            else if (titCond == 2)
            { Console.WriteLine("Indique los datos del conductor"); }
            Console.WriteLine("");

            Conductor conductor = new Conductor();
            conductor.Cond();
            Console.WriteLine("");
            conductor.DatosCond();
            Console.WriteLine("");
            conductor.tipoLicenciaCond();
            
            if (menu == 1)
            { while (conductor.comprobarLicenCondcoche(conductor.licenciaCond) == false)
                { Console.WriteLine("El conductor no tiene la licencia necesaria para este vehiculo"); }
            if (conductor.comprobarLicenCondcoche(conductor.licenciaCond) == true)
                { Console.WriteLine("El conductor tiene la licencia necesaria para conducir el vehiculo"); }
            }

            if (menu == 2)
            {
                while (conductor.comprobarLicenCondcoche(conductor.licenciaCond) == false)
                { Console.WriteLine("El conductor no tiene la licencia necesaria para este vehiculo"); }
                if (conductor.comprobarLicenCondcoche(conductor.licenciaCond) == true)
                { Console.WriteLine("El conductor tiene la licencia necesaria para conducir el vehiculo"); }
            }

            if (menu == 3)
            {
                while (conductor.comprobarLicenCondcoche(conductor.licenciaCond) == false)
                { Console.WriteLine("El conductor no tiene la licencia necesaria para este vehiculo"); }
                if (conductor.comprobarLicenCondcoche(conductor.licenciaCond) == true)
                { Console.WriteLine("El conductor tiene la licencia necesaria para conducir el vehiculo"); }
            }



            Console.ReadKey();
        }


    }
}