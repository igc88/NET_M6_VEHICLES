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
        public string marca = string.Empty;
        public string matricula = string.Empty;
        public string color = string.Empty;

        public  int NumRuedasDelanteras = 0;
        public int NumRuedasTraseras = 0;

        public List<Rueda> ruedasDelanteras = new List<Rueda>();
        public List<Rueda> ruedasTraseras = new List<Rueda>();

        // METODOS
        public bool comprobarMatricula(string matricula) {
            if ((matricula.Length > 7) && (matricula.Length < 6)) { return false; }
            if (numsMatricula(matricula)!=4 && (letrasMatricula(matricula)<2 || letrasMatricula(matricula)>3)) { return false; }
            
            return true;
        }
        public int numsMatricula(string matricula) {
            string numeros= "0123456789";
            int num = 0;
            for (int i = 0; i < matricula.Length; i++)
            {
                if (numeros.Contains(matricula[i]))
                    num++;
            }
            return num;
        }
        public int letrasMatricula(string matricula) {
            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int cont = 0;
            for (int i = 0; i < matricula.Length; i++) {
                if (caracteres.Contains(matricula[i])) {
                    cont += 1;
                }
            }
            return cont;
        }

        public void anadirRuedas() {
            Console.WriteLine("Introduce la marca de la rueda: ");

            string marcaRueda = Console.ReadLine();
            double diametro = 0;

            while (diametro <= 0.4 || diametro >= 4) {
                Console.WriteLine("Introduce el diametro de la rueda (: ");
                diametro = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < this.NumRuedasDelanteras; i++) {
                this.ruedasDelanteras.Add(new Rueda(marcaRueda, diametro));
            }

            for (int i = 0; i < this.NumRuedasTraseras; i++) {
                this.ruedasTraseras.Add(new Rueda(marcaRueda, diametro));
            }
        }
    }
}

    
