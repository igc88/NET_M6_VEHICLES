using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    class Licencia
    {
        public int ID;
        public char tipoLicen;
        public string nomLicen;
        public string caducidadLicen;

        public Licencia(int ID, char tipoLicen, string nomLicen, string caducidadLicen)
        {
            this.ID = ID;
            this.tipoLicen = tipoLicen;
            this.nomLicen = nomLicen;
            this.caducidadLicen = caducidadLicen;
        }

        public int tipoLicencia()
        {
            if (tipoLicen == 'A') { Console.WriteLine("Tiene licencia de coche"); }
            if (tipoLicen == 'B') { Console.WriteLine("Tiene licencia de moto"); }
            if (tipoLicen == 'C') { Console.WriteLine("Tiene licencia de camion"); }
            return tipoLicen;
        }

        public bool comprobarIDcoche(char tipoLicen)
        {
            if (tipoLicen == 'A') { return true; }
            if (ID != 'A') { return false; }
            return true;
        }
        public bool comprobarIDmoto(char tipoLicen)
        {
            if (tipoLicen == 'B') { return true; }
            if (tipoLicen != 'B') { return false; }
            return true;
        }
        public bool comprobarIDcamion(char tipoLicen)
        {
            if (tipoLicen == 'C') { return true; }
            if (tipoLicen != 'C') { return false; }
            return true;
        }
        public void DatosLicen()
        { 
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Tipo de licencia: " + tipoLicen);
            Console.WriteLine("Nombre de la licencia: " + nomLicen);
            Console.WriteLine("Fecha de caducidad de la licencia: " + caducidadLicen);
        }



    }
}
