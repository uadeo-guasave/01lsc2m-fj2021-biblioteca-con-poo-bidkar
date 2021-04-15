using System;

namespace biblioteca
{
    class Biblioteca
    {
        public int Id { get; set; }

        public Biblioteca()
        {
            var rnd = new Random();
            Id = rnd.Next(1000);
        }
    }
}