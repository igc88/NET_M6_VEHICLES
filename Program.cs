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

            Program cocheOmoto = new Program();
            int menu;
            Console.WriteLine("Que desea crear? \n1) Coche \n2) Moto");



            menu = Convert.ToInt32(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    Console.WriteLine("Has seleccionado coche");
                    Console.WriteLine("");
                    cocheOmoto.coche();
                    break;
                case 2:
                    Console.WriteLine("Has seleccionado moto");
                    Console.WriteLine("");
                    cocheOmoto.moto();
                    break;
            }

            Console.ReadKey();
        }

        public void coche()
        {
            // SE PIDEN LOS DATOS DEL COCHE
            // SE CREA EL COCHE
            // SE COMPRUEBA QUE LA MATRICULA SEA CORRECTA

            Console.WriteLine("Introduce la matricula del coche: ");
            string matricula = Console.ReadLine();
            Console.WriteLine("Introduce la marca del coche: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduce el color del coche: ");
            string color = Console.ReadLine();
            Console.WriteLine("");

            Coche coche = new Coche(matricula, marca, color);

            while (coche.comprobarMatricula(coche.matricula) == false)
            {
                Console.WriteLine("La matricula es incorrecta. Repita los datos");
            }
            if (coche.comprobarMatricula(coche.matricula))
            { Console.WriteLine("Continue"); }
            Console.WriteLine("");

            // SE PIDE LA INFORMACION DE LAS RUEDAS: MARCA Y DIAMETRO 
            // SE CREAN LAS RUEDAS
            // SE COMPRUEBA QUE EL DIAMETRO SEA CORRECTO

            Console.WriteLine("Introduce la marca de las ruedas: ");
            string marcaRueda = Console.ReadLine();
            Console.WriteLine("Introduce el diametro de la rueda: ");
            double diametro = double.Parse(Console.ReadLine());

            Rueda rueda = new Rueda(marcaRueda, diametro);

            while (rueda.comprobarDiametro(coche.diametroRueda) == false)
            { Console.WriteLine("El diametro no esta dentro del establecido"); }
            if (rueda.comprobarDiametro(coche.diametroRueda))
            { Console.WriteLine("Continue"); }
            Console.WriteLine("");

            for (int i = 0; i < coche.NumRuedasDelanteras; i++)
            {
                coche.ruedasDelanteras.Add(new Rueda(marcaRueda, diametro));
            }
            for (int i = 0; i < coche.NumRuedasTraseras; i++)
            {
                coche.ruedasTraseras.Add(new Rueda(marcaRueda, diametro));
            }
            coche.datosCoche();
        }
         public void moto()
         {     
                      // SE PIDEN LOS DATOS DE LA MOTO
                      // SE CREA LA MOTO
                      // SE COMPRUEBA QUE LA MATRICULA SEA CORRECTA

            Console.WriteLine("Introduce la matricula de la moto: ");
            string matricula = Console.ReadLine();
            Console.WriteLine("Introduce la marca de la moto: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduce el color de la moto: ");
            string color = Console.ReadLine();
            Console.WriteLine("");

            Moto moto = new Moto(matricula, marca, color);

            while (moto.comprobarMatricula(moto.matricula) == false)
            {
                Console.WriteLine("La matricula es incorrecta. Repita los datos");
            }
            if (moto.comprobarMatricula(moto.matricula))
            { Console.WriteLine("Continue"); }
            Console.WriteLine("");

            // SE PIDE LA INFORMACION DE LAS RUEDAS: MARCA Y DIAMETRO 
            // SE CREAN LAS RUEDAS
            // SE COMPRUEBA QUE EL DIAMETRO SEA CORRECTO

            Console.WriteLine("Introduce la marca de las ruedas: ");
            string marcaRueda = Console.ReadLine();
            Console.WriteLine("Introduce el diametro de la rueda: ");
            double diametro = double.Parse(Console.ReadLine());

            Rueda rueda = new Rueda(marcaRueda, diametro);

            while (rueda.comprobarDiametro(moto.diametroRueda) == false)
            { Console.WriteLine("El diametro no esta dentro del establecido"); }
            if (rueda.comprobarDiametro(moto.diametroRueda))
            { Console.WriteLine("Continue"); }
            Console.WriteLine("");

            for (int i = 0; i < moto.NumRuedasDelanteras; i++)
            {
                moto.ruedasDelanteras.Add(new Rueda(marcaRueda, diametro));
            }
            for (int i = 0; i < moto.NumRuedasTraseras; i++)
            {
                moto.ruedasTraseras.Add(new Rueda(marcaRueda, diametro));
            }

            moto.datosMoto();
        }
    }
}