using System;

namespace biblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            CrearEditoriales();
        }

        private static void CrearEditoriales()
        {
            var editorial1 = new Editorial();
            editorial1.Nombre = "Trillas";
            editorial1.Domicilio = "CDMX";
            editorial1.País = "México";
            editorial1.Teléfono = "5201000000";
            editorial1.CorreoElectrónico = "ventas@trillas.com";
            editorial1.SitioWeb = "https://trillas.com";
            Console.WriteLine("Editorial Id:" + editorial1.Id);
            Console.WriteLine("Editorial Nombre:" + editorial1.Nombre);
            Console.WriteLine("Editorial Domicilio:" + editorial1.Domicilio);
            Console.WriteLine("Editorial País:" + editorial1.País);
            Console.WriteLine("Editorial Teléfono:" + editorial1.Teléfono);
            Console.WriteLine("Editorial CorreoElectrónico:" + editorial1.CorreoElectrónico);
            Console.WriteLine("Editorial SitioWeb:" + editorial1.SitioWeb);
        }
    }
}
