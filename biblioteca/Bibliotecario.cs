namespace biblioteca
{
    class Bibliotecario : Biblioteca
    {
        public string Nombre { get; set; }
        public int NúmeroDeEmpleado { get; set; }

        public Bibliotecario() : base() { }
    }
}