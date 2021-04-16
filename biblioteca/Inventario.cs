using System;

namespace biblioteca
{
    class Inventario : Biblioteca
    {
        public Libro Libro { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public int FolioDesde { get; set; }
        public int FolioHasta { get; set; }

        public Inventario() : base() { }
    }
}