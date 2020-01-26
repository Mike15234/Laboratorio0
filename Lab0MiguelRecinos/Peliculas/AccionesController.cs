using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lab0MiguelRecinos.Peliculas
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccionesController : ControllerBase
    {
        [HttpGet]
        public List<Peliculas> Publicar()
        {
            if (Peliculas.Instancia.peliculas.Count <= 10)
            {
                return Peliculas.Instancia.peliculas;
            }
            else
            {
                List<Peliculas> nuevaLista = new List<Peliculas>();
                nuevaLista = Peliculas.Instancia.peliculas.GetRange((Peliculas.Instancia.peliculas.Count - 10), 10);
                return nuevaLista;
            }
        }

        [HttpPost]
        public Peliculas Obtener([FromBody]string name, [FromBody]string autor, [FromBody]string estreno)
        {
            Peliculas peliculas = new Peliculas();
            peliculas.Nombre = name;
            peliculas.Director = autor;
            peliculas.Estreno = estreno;
            Peliculas.Instancia.peliculas.Add(peliculas);
            return peliculas;
        }
    }
}