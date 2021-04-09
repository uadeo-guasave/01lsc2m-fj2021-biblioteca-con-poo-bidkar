using System;

namespace biblioteca
{
    class Editorial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string País { get; set; }
        public string Teléfono { get; set; }
        public string CorreoElectrónico { get; set; }
        public string SitioWeb { get; set; }

        public Editorial() {
            // constructor: se ejecuta al crear el objeto
            var rnd = new Random();
            Id = rnd.Next(1000);
        }

        // ~Editorial() {
        //     // destructor: se ejecuta al final de la vida del objeto
        // }
    }
}