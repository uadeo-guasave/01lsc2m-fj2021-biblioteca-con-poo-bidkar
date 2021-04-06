using System;

namespace biblioteca
{
    class Inventario
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        public int Existencia { get; set; }
        public DateTime FechaDeIngreso { get; set; }
        public int FolioDesde { get; set; }
        public int FolioHasta { get; set; }
    }
}