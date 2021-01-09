namespace NET_M6
{
    public interface IPersona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FechaNacimiento { get; set; }
        public Licencia LicenciaConducir { get; set; }

    }
}
