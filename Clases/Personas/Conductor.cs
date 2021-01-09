using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    class Conductor
    {
        // ATRIBUTOS
        public string nomCond;
        public string apellCond;
        public string fechanacCond;
        public char licenciaCond;

        // METODOS
        public void Cond()
        {
            Console.WriteLine("Nombre del conductor: ");
            nomCond = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Apellidos del conductor: ");
            apellCond = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Fecha de nacimiento del conductor: ");
            fechanacCond = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Que tipo de licencia tiene? \nA) Coche \nB) Moto \nC) Camion");
            licenciaCond = Convert.ToChar(Console.ReadLine());
        }
        public void DatosCond()
        { 
            Console.WriteLine("El nombre del conductor es: " + nomCond);
            Console.WriteLine("Los apellidos del conductor son: " + apellCond);
            Console.WriteLine("La fecha de nacimiento del conductor es: " + fechanacCond);
            Console.WriteLine("El conductor tiene licencia tipo: " + licenciaCond);
        }
        public int tipoLicenciaCond()
        {
            if (licenciaCond == 'A') { Console.WriteLine("Tiene licencia de coche"); }
            if (licenciaCond == 'B') { Console.WriteLine("Tiene licencia de moto"); }
            if (licenciaCond == 'C') { Console.WriteLine("Tiene licencia de camion"); }
            return licenciaCond;
        }
        public bool comprobarLicenCondcoche(char licenciaCond)
        {
            if (licenciaCond == 'A') { return true; }
            if (licenciaCond != 'A') { return false; }
            return true;
        }
        public bool comprobarLicenCondmoto(char licenciaCond)
        {
            if (licenciaCond == 'B') { return true; }
            if (licenciaCond != 'B') { return false; }
            return true;
        }
        public bool comprobarLicenCondcamion(char licenciaCond)
        {
            if (licenciaCond == 'C') { return true; }
            if (licenciaCond != 'C') { return false; }
            return true;
        }

    }
}
