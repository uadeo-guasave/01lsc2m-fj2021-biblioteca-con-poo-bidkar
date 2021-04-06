using System;
using System.Collections.Generic;

namespace biblioteca
{
    class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public Editorial Editorial { get; set; }
        public DateTime FechaDeEdición { get; set; }
        public List<Autor> Autores { get; set; }
        public List<Categoria> Categorías { get; set; }
        public int NúmeroDePáginas { get; set; }
        public string Isbn { get; set; }
        public string Idioma { get; set; }
        public string Portada { get; set; }
    }
}