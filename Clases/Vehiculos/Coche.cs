using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 
{
    class Coche : Vehiculo 
    {
        // ATRIBUTOS
        public int NumRuedasDelanteras = 2 ;
        public int NumRuedasTraseras = 2;
        
        // CONSTRUCTORES
        public Coche(string matricula, string marca, string color) 
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        public void datosCoche()
        {
            Console.WriteLine("Matricula del coche: " + base.matricula);
            Console.WriteLine("Marca del coche: " + base.marca);
            Console.WriteLine("Color del coche: " + base.color);
        }
    }
}
