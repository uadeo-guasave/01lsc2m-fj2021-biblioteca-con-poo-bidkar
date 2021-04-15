namespace biblioteca
{
    class Categoria : Biblioteca
    {
        public string Nombre { get; set; }
        public Categoria CategoriaPadre { get; set; }

        public Categoria() : base() { }
    }
}