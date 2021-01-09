using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    class Vehiculo
    {
        // ATRIBUTOS
        public string marca;
        public string matricula;
        public string color;
        public double diametroRueda;

        // METODOS
        public bool comprobarMatricula(string matricula)
        {
            if ((matricula.Length > 7) || (matricula.Length < 6)) { return false; }
            if (numsMatricula(matricula) != 4 && (letrasMatricula(matricula) < 2 || letrasMatricula(matricula) > 3)) { return false; }
            return true;
        }
        public int numsMatricula(string matricula)
        {
            string numeros = "0123456789";
            int num = 0;
            for (int i = 0; i < matricula.Length; i++)
            {
                if (numeros.Contains(matricula[i]))
                    num++;
            }
            return num;
        }
        public int letrasMatricula(string matricula)
        {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int cont = 0;
            for (int i = 0; i < matricula.Length; i++)
            {
                if (caracteres.Contains(matricula[i]))
                {
                    cont += 1;
                }
            }
            return cont;
        }

        public List<Rueda> ruedasDelanteras = new List<Rueda>();
        public List<Rueda> ruedasTraseras = new List<Rueda>();

        public void anadirRuedaDel(string marca, double diametro)
        {
            bool delantera = true;
            if (delantera)
            {
                ruedasDelanteras.Add(new Rueda(marca, diametro));
            }
        }
        public void anadirRuedaTras(string marca, double diametro)
        {
            bool trasera = true;
            if (trasera)
            {
            ruedasTraseras.Add(new Rueda(marca, diametro));
            }
        }


        public void coche()
        {
            // SE PIDEN LOS DATOS DEL COCHE
            // SE CREA EL COCHE
            // SE COMPRUEBA QUE LA MATRICULA SEA CORRECTA

            Console.WriteLine("Introduce la matricula del coche: ");
            matricula = Console.ReadLine();
            Console.WriteLine("Introduce la marca del coche: ");
            marca = Console.ReadLine();
            Console.WriteLine("Introduce el color del coche: ");
            color = Console.ReadLine();

            Coche coche = new Coche(matricula, marca, color);

            while (coche.comprobarMatricula(coche.matricula) == false)
            {
                Console.WriteLine("La matricula es incorrecta. Repita los datos");
            }
            if (coche.comprobarMatricula(coche.matricula))
            Console.WriteLine("");
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

            // SE MUESTRAN LOS DATOS RELATIVOS A COCHE
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
                Console.WriteLine("");
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

            // SE MUESTRAN LOS DATOS RELATIVOS A MOTO
            moto.datosMoto();
        }
        public void camion()
        {
            // SE PIDEN LOS DATOS DEL CAMION
            // SE CREA EL CAMION
            // SE COMPRUEBA QUE LA MATRICULA SEA CORRECTA

            Console.WriteLine("Introduce la matricula del camion: ");
            string matricula = Console.ReadLine();
            Console.WriteLine("Introduce la marca del camion: ");
            string marca = Console.ReadLine();
            Console.WriteLine("Introduce el color del camion: ");
            string color = Console.ReadLine();
            Console.WriteLine("");

            Camion camion = new Camion(matricula, marca, color);

            while (camion.comprobarMatricula(camion.matricula) == false)
            {
                Console.WriteLine("La matricula es incorrecta. Repita los datos");
            }
            if (camion.comprobarMatricula(camion.matricula))
                Console.WriteLine("");
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

            while (rueda.comprobarDiametro(camion.diametroRueda) == false)
            { Console.WriteLine("El diametro no esta dentro del establecido"); }
            if (rueda.comprobarDiametro(camion.diametroRueda))
            { Console.WriteLine("Continue"); }
            Console.WriteLine("");

            for (int i = 0; i < camion.NumRuedasDelanteras; i++)
            {
                camion.ruedasDelanteras.Add(new Rueda(marcaRueda, diametro));
            }
            for (int i = 0; i < camion.NumRuedasTraseras; i++)
            {
                camion.ruedasTraseras.Add(new Rueda(marcaRueda, diametro));
            }

            // SE MUESTRAN LOS DATOS RELATIVOS AL CAMION
            camion.datosCamion();
        }
    }
}
    
    




    
