using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab0MiguelRecinos.Peliculas
{
    public class Peliculas
    {
        private static Peliculas _instancia;
        public static Peliculas Instancia { get { if (_instancia == null) _instancia = new Peliculas();
                return _instancia;
            } }
        public string Nombre;
        public string Estreno;
        public string Director;
        public List<Peliculas> peliculas = new List<Peliculas>();
    }
}
