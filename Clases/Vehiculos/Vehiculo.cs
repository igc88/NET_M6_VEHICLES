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

        }
    }
    
    




    
