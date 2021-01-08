using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_M6 {
    public class Vehiculo : IVehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int NumRuedas { get; set; }

        // public IEnumerable<IRueda> Ruedas { get; set; }
        public IEnumerable<IRueda> RuedasDelanteras { get; set; }
        public IEnumerable<IRueda> RuedasTraseras { get; set; }

        public Vehiculo(string matricula, string marca, string color, int numRuedas)
        {
            Matricula = matricula;
            Marca = marca;
            Color = color;
            NumRuedas = numRuedas;
            //Ruedas = new List<IRueda>();
            RuedasDelanteras = new List<IRueda>();
            RuedasTraseras = new List<IRueda>();

            if (!ComprobarMatricula())
                throw new ArgumentException("Debe contener 4 números y 2 o 3 letras", nameof(matricula));
        }

        public bool ComprobarMatricula()
        {
            var cantidadNumeros = Matricula.Count(x => Char.IsDigit(x));
            var cantidadLetras = Matricula.Count(x => Char.IsLetter(x));
            return cantidadNumeros == 4 && (cantidadLetras == 2 || cantidadLetras == 3);
        }
    }
}
