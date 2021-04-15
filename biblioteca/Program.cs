using System;

namespace biblioteca
{
    class Program
    {
        static Editorial editorial1 = new Editorial();
        static Autor autor1 = new Autor();
        static Autor autor2 = new Autor();
        static Categoria categoria1 = new Categoria();
        static Categoria categoria2 = new Categoria();
        static Libro libro1 = new Libro();
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Crear editoriales
            CrearEditoriales();

            // Crear autores
            CrearAutores();

            // Crear categorias
            CrearCategorias();

            // Crear libros
            CrearLibros();

            // imprimir libros
            libro1.Imprimir();
        }

        static void CrearLibros()
        {
            // var libro1 = new Libro();
            libro1.Titulo = "PHP Fullstack";
            libro1.Editorial = editorial1;
            libro1.FechaDeEdición = new DateTime(2005, 10, 16);
            libro1.Autores.Add(autor1);
            libro1.Autores.Add(autor2);
            libro1.Categorías.Add(categoria2);
            libro1.NúmeroDePáginas = 230;
            libro1.Isbn = "9781234567897";
            libro1.Idioma = "Español";
            libro1.Portada = "images/portada.png";
            Console.WriteLine("Libro creado correctamente");
        }

        static void CrearCategorias()
        {
            categoria1.Nombre = "Computación";
            categoria1.CategoriaPadre = null;
            categoria2.Nombre = "Lenguajes de programación";
            categoria2.CategoriaPadre = categoria1;
            Console.WriteLine("Categorias creadas correctamente");
        }

        static void CrearAutores()
        {
            autor1.Nombre = "Nestor";
            autor1.Apellido = "Cerecer";
            autor2.Nombre = "Jose Luis";
            autor2.Apellido = "Gaxiola";
            Console.WriteLine("Autores creados correctamente");
        }

        static void CrearEditoriales()
        {
            // var editorial1 = new Editorial();
            editorial1.Nombre = "Trillas";
            editorial1.Domicilio = "CDMX";
            editorial1.País = "México";
            editorial1.Teléfono = "5201000000";
            editorial1.CorreoElectrónico = "ventas@trillas.com";
            editorial1.SitioWeb = "https://trillas.com";
            // Console.WriteLine("Editorial Id:" + editorial1.Id);
            // Console.WriteLine("Editorial Nombre:" + editorial1.Nombre);
            // Console.WriteLine("Editorial Domicilio:" + editorial1.Domicilio);
            // Console.WriteLine("Editorial País:" + editorial1.País);
            // Console.WriteLine("Editorial Teléfono:" + editorial1.Teléfono);
            // Console.WriteLine("Editorial CorreoElectrónico:" + editorial1.CorreoElectrónico);
            // Console.WriteLine("Editorial SitioWeb:" + editorial1.SitioWeb);
            Console.WriteLine($"Editorial creada correctamente con el Id:{editorial1.Id}");
        }
    }
}
