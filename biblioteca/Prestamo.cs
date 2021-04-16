using System;
using System.Collections.Generic;
using System.Linq;

namespace biblioteca
{
    class Prestamo : Biblioteca
    {
        public DateTime FechaDeSalida { get; set; }
        public DateTime FechaDeRetorno { get; set; }
        public Solicitante Solicitante { get; set; }
        public Bibliotecario Bibliotecario { get; set; }
        public List<int> FoliosDeLibros { get; set; } = new List<int>();

        public Prestamo() : base() { }

        public void ImprimirComprobanteDeSalida()
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Biblioteca UAdeO Guasave");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Préstamo externo de libros\n");
            Console.WriteLine($"Fecha de salida: {FechaDeSalida}");
            Console.WriteLine($"Solicitante: {Solicitante.Nombre}");
            Console.WriteLine($"Bibliotecario: {Bibliotecario.Nombre}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("ID    LIBRO");
            Console.WriteLine("---------------------------------------");
            foreach (var folio in FoliosDeLibros)
            {
                // obtener cada libro a partir de su folio
                Libro libro = Program.inventarios.First(i => folio >= i.FolioDesde && folio <= i.FolioHasta).Libro;
                Console.WriteLine($"{folio}    {libro.Titulo}");
            }
            Console.WriteLine("\n");
        }
    }
}