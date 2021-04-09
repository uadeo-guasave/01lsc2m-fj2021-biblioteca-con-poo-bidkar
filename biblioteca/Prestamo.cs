using System;
using System.Collections.Generic;

namespace biblioteca
{
    class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaDeSalida { get; set; }
        public DateTime FechaDeRetorno { get; set; }
        public Solicitante Solicitante { get; set; }
        public Bibliotecario Bibliotecario { get; set; }
        public List<int> FoliosDeLibros { get; set; }
    }
}