namespace biblioteca
{
    class Solicitante : Biblioteca
    {
        public string Nombre { get; set; }
        public string Teléfono { get; set; }
        public string CorreoElectrónico { get; set; }
        public string Domicilio { get; set; }

        public Solicitante() : base() { }
    }
}