using System;

namespace biblioteca
{
    class Editorial : Biblioteca
    {
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string País { get; set; }
        public string Teléfono { get; set; }
        public string CorreoElectrónico { get; set; }
        public string SitioWeb { get; set; }

        public Editorial() : base() { }

        // ~Editorial() {
        //     // destructor: se ejecuta al final de la vida del objeto
        // }
    }
}