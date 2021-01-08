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
        public int ruedaDel;
        public int ruedaTras;

        // METODOS
        public bool comprobarMatricula(string matricula)
        {
            if (matricula.Length > 8) { return false; }
            if (numsMatricula(matricula)!=4 && (letrasMatricula(matricula)<2 || letrasMatricula(matricula)>3)) { return false; }
            return true;
        }
        public int numsMatricula(string matricula)
        {
            string numeros= "0123456789";
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
    }
}

    
