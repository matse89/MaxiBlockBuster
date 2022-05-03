using MaxiBlockBuster.DAL;
using MaxiBlockBuster.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiBlockBuster.BLL.Services
{
    public class PeliculaService
    {
        private readonly BlockBusterDbContext _context;

        public PeliculaService(BlockBusterDbContext context)
        {
            _context = context;
        }
        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> pelis = _context.Peliculas.ToList();

            return pelis;
        }

        public int AgregarPelicula(string nombre)
        {
            var existe = _context.Peliculas.Any(e => e.Nombre == nombre);

            if (existe)
            {
                throw new Exception("YA EXISTE");
            }

            Pelicula pelicula = new Pelicula();

            pelicula.Nombre = nombre;

            _context.Peliculas.Add(pelicula);

            _context.SaveChanges();

            return pelicula.PeliculaId;
        }
    }
}
