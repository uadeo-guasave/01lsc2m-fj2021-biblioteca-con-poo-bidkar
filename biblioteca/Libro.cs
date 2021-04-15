using System;
using System.Collections.Generic;

namespace biblioteca
{
    class Libro : Biblioteca
    {
        public string Titulo { get; set; }
        public Editorial Editorial { get; set; }
        public DateTime FechaDeEdición { get; set; }
        public List<Autor> Autores { get; set; } = new List<Autor>();
        public List<Categoria> Categorías { get; set; } = new List<Categoria>();
        public int NúmeroDePáginas { get; set; }
        public string Isbn { get; set; }
        public string Idioma { get; set; }
        public string Portada { get; set; }

        public Libro() : base() { }

        public void Imprimir()
        {
            Console.WriteLine($"Libro {Id}: {Titulo}");
            Console.WriteLine($"Editorial {Editorial.Id}: {Editorial.Nombre}");
            Console.WriteLine($"Edición: {FechaDeEdición.ToString()}");

            // imprimir autores
            if (Autores.Count == 0) {
                // imprimir autor anonimo
                Console.WriteLine("Autor anónimo");
            } else if (Autores.Count == 1) {
                Console.WriteLine($"Autor {Autores[0].Id}: {Autores[0].Nombre} {Autores[0].Apellido}");
            } else {
                // cuando haya mas de un autor
                foreach (var autor in Autores)
                {
                    Console.WriteLine($"Autor {autor.Id}: {autor.Nombre} {autor.Apellido}");
                }
            }

            // imprimir categorias
            if (Categorías.Count > 0) {
                foreach (var categoria in Categorías)
                {
                    Console.WriteLine($"Categoria {categoria.Id}: {categoria.Nombre}");
                }
            } else {
                Console.WriteLine("Sin categorias");
            }

            Console.WriteLine($"Páginas: {NúmeroDePáginas}");
            Console.WriteLine($"ISBN: {Isbn}");
            Console.WriteLine($"Idioma: {Idioma}");
            Console.WriteLine($"Postada: {Portada}");

        }
    }
}