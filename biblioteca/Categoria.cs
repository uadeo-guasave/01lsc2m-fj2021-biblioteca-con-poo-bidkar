namespace biblioteca
{
    class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Categoria CategoriaPadre { get; set; }
    }
}