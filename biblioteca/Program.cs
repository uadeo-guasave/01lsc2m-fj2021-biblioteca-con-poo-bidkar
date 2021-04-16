using System;
using System.Collections.Generic;

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
        static Alumno alumno1 = new Alumno();
        static Docente docente1 = new Docente();
        static Bibliotecario bibliotecario1 = new Bibliotecario();
        public static List<Inventario> inventarios = new List<Inventario>();
        static Prestamo prestamo1 = new Prestamo();
        static Prestamo prestamo2 = new Prestamo();
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

            // crear alumnos
            CrearAlumnos();

            // crear docentes
            CrearDocentes();

            // crear bibliotecario
            CrearBibliotecario();

            // crear inventarios
            CrearInventarios();

            // crear prestamos
            CrearPrestamos();

            // imprimir comprobante de salida
            prestamo1.ImprimirComprobanteDeSalida();
            prestamo2.ImprimirComprobanteDeSalida();
        }

        static void CrearPrestamos()
        {
            prestamo1.FechaDeSalida = new DateTime(2021,04,15);
            prestamo1.Solicitante = alumno1;
            prestamo1.Bibliotecario = bibliotecario1;
            // prestamo1.FoliosDeLibros = new List<int>();
            prestamo1.FoliosDeLibros.Add(1);

            prestamo2.FechaDeSalida = new DateTime(2021,04,10);
            prestamo2.FechaDeRetorno = new DateTime(2021,04,12);
            prestamo2.Solicitante = docente1;
            prestamo2.Bibliotecario = bibliotecario1;
            prestamo2.FoliosDeLibros.Add(9);

            Console.WriteLine("Prestamos creados correctamente");
        }

        static void CrearInventarios()
        {
            var ejemplares1 = new Inventario {
                Libro = libro1,
                Existencia = 10,
                FechaDeIngreso = new DateTime(2021,04,01),
                FolioDesde = 1,
                FolioHasta = 10
            };

            inventarios.Add(ejemplares1);
            Console.WriteLine("Inventarios creados correctamente");
        }

        static void CrearBibliotecario()
        {
            bibliotecario1.Nombre = "Monica Gaxiola";
            bibliotecario1.NúmeroDeEmpleado = 2000;

            Console.WriteLine("Bibliotecario creado correctamente");
        }

        static void CrearDocentes()
        {
            docente1.Nombre = "Juan Carlos Lopez";
            docente1.Teléfono = "6871234567";
            docente1.CorreoElectrónico = "juan.lopez@uadeo.mx";
            docente1.Domicilio = "Guasave";
            docente1.NúmeroDeEmpleado = 1200;
            docente1.Departamento = "Ciencias Economico-Administrativas";

            Console.WriteLine("Docente creado correctamente");
        }

        static void CrearAlumnos()
        {
            alumno1.Nombre = "Bidkar Aragón";
            alumno1.Teléfono = "6871234567";
            alumno1.CorreoElectrónico = "alumno1@uadeo.mx";
            alumno1.Domicilio = "Guasave";
            alumno1.Matricula = "9730035";
            alumno1.Carrera = "Sistemas Computacionales";
            alumno1.Semestre = 2;

            Console.WriteLine("Alumno creado correctamente");
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
