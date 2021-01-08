﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6.Utilidades
{
    public static class Consola
    {
        public static string PedirString(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine();
        }

        public static double PedirDouble(string mensaje)
        {
            Console.WriteLine(mensaje);
            double d = 0;
            bool esDouble = false;
            while(!esDouble)
            {
                esDouble = double.TryParse(Console.ReadLine(), out d);
                if (!esDouble)
                {
                    Console.WriteLine("Introduce un double");
                }
            };
            return d;

        }
    }
}
