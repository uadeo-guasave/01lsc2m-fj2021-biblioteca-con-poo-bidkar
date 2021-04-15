namespace biblioteca
{
    class Autor : Biblioteca
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Autor() : base() {}
    }
}