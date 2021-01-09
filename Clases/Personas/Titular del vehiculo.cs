using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{

    class Titular
    {
        public string nomTitular;
        public string apellTitular;
        public string fechanacTitular;
        public bool licenciaTitular;
        public bool seguro;
        public bool garage;
        public Titular(string nomTitular, string apellTitular, string fechanacTitular, bool licenciaTitular, bool seguro, bool garage)
        {
            this.nomTitular = nomTitular;
            this.apellTitular = apellTitular;
            this.fechanacTitular = fechanacTitular;
            this.licenciaTitular = licenciaTitular;
            this.seguro = seguro;
            this.garage = garage;
        }

        public bool comprobarLicencia(bool licenciaTitular)
        {
            if (licenciaTitular == true) { return true; }
            if (licenciaTitular == false) { }
            return licenciaTitular;
        }

        public void datosTitular()
        {
            Console.WriteLine("Nombre del titular: " + nomTitular);
            Console.WriteLine("Apellido del titular: " + apellTitular);
            Console.WriteLine("Fecha de nacimiento del titular: " + fechanacTitular);
            Console.WriteLine("Tiene licencia? " + licenciaTitular);
            Console.WriteLine("Tiene seguro? " + seguro);
            Console.WriteLine("Tiene garage? " + garage );
        }

    }
}
