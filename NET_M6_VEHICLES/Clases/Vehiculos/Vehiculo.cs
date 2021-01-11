using System;
using System.Collections.Generic;
using System.Linq;
using static NET_M6.Utilidades.Consola;

namespace NET_M6
{
    public class Vehiculo : IVehiculo
    {
        public string Matricula { get; set; }
        public string Marca { get; set; }
        public string Color { get; set; }
        public int NumRuedasDelanteras { get; set; }
        public int NumRuedasTraseras { get; set; }
        public IEnumerable<IRueda> RuedasDelanteras { get; set; }
        public IEnumerable<IRueda> RuedasTraseras { get; set; }
        public char TiposLicencia { get; set; }
        public Titular Titular { get; set; }
        public Conductor Conductor { get; set; }
        public IEnumerable<IPersona> ListaPersonas { get; set; }

        public Vehiculo(string matricula, string marca, string color, int numRuedasDelanteras, int numRuedasTraseras, char tiposLicencia)
        {
            Matricula = matricula;
            Marca = marca;
            Color = color;
            NumRuedasDelanteras = numRuedasDelanteras;
            NumRuedasTraseras = numRuedasTraseras;
            RuedasDelanteras = new List<IRueda>();
            RuedasTraseras = new List<IRueda>();
            TiposLicencia = tiposLicencia;
            ListaPersonas = new List<IPersona>();

            if (!ComprobarMatricula())
                throw new ArgumentException("Debe contener 4 números y 2 o 3 letras", nameof(matricula));
        }

        public bool ComprobarMatricula()
        {
            var cantidadNumeros = Matricula.Count(x => Char.IsDigit(x));
            var cantidadLetras = Matricula.Count(x => Char.IsLetter(x));
            return cantidadNumeros == 4 && (cantidadLetras == 2 || cantidadLetras == 3);
        }

        public void AñadirRuedas()
        {
            var marcaDelanteras = PedirString("Introduce la marca de las ruedas delanteras:");
            var diametroDelanteras = PedirDouble("Introduce el diámetro de las ruedas delanteras:");
            var ruedasDelanteras = new List<IRueda>();
            for (int i = 0; i < NumRuedasDelanteras; i++)
            {
                ruedasDelanteras.Add(new Rueda(marcaDelanteras, diametroDelanteras));
            }
            RuedasDelanteras = ruedasDelanteras;

            var marcaTraseras = PedirString("Introduce la marca de las ruedas traseras:");
            var diametroTraseras = PedirDouble("Introduce el diámetro de las ruedas traseras:");
            var ruedasTraseras = new List<IRueda>();
            for (int i = 0; i < NumRuedasTraseras; i++)
            {
                ruedasTraseras.Add(new Rueda(marcaTraseras, diametroTraseras));
            }
            RuedasTraseras = ruedasTraseras;
        }

        public override string ToString()
        {
            return @$"Matricula: {Matricula} Licencia: {TiposLicencia} ";
        }

    }
}
