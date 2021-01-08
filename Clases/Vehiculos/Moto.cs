using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    class Moto : Vehiculo
    {
        // ATRIBUTOS
        public int NumRuedasDelanteras = 1;
        public int NumRuedasTraseras = 1;

        // CONSTRUCTORES
        public Moto(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        //METODOS
        public void datosMoto()
        {
            Console.WriteLine("Matricula de la moto: " + matricula);
            Console.WriteLine("Marca de la moto: " + marca);
            Console.WriteLine("Color de la moto: " + color);
        }
    }
}