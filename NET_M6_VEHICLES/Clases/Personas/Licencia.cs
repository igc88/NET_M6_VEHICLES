namespace NET_M6
{
    public class Licencia
    {
        public int Id { get; set; }
        public char TiposLicencia { get; set; }
        public string NombreCompleto { get; set; }
        public string FechaCaducar { get; set; }

        public Licencia(int id, char tiposLicencia, string nombreCompleto, string fechaCaducar)
        {
            Id = id;
            TiposLicencia = tiposLicencia;
            NombreCompleto = nombreCompleto;
            FechaCaducar = fechaCaducar;
        }
    }
}
