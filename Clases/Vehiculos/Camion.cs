using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6
{
    class Camion : Vehiculo
    {
        public int NumRuedasDelanteras = 4;
        public int NumRuedasTraseras = 6;

        public Camion(string matricula, string marca, string color)
        {
            this.matricula = matricula;
            this.marca = marca;
            this.color = color;
        }

        public void datosCamion()
        {
            Console.WriteLine("Matricula del camion: " + base.matricula);
            Console.WriteLine("Marca del camion: " + base.marca);
            Console.WriteLine("Color del camion: " + base.color);
        }

    }
}
