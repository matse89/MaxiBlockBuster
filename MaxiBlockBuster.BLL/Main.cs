using MaxiBlockBuster.BLL.Services;
using MaxiBlockBuster.DAL;
using MaxiBlockBuster.Model;

namespace MaxiBlockBuster.BLL
{
    public interface IMain
    {
        PeliculaService Peliculas { get; }
    }

    public class Main : IMain
    {
        private readonly BlockBusterDbContext _context;
        private PeliculaService _pelicula;

        public Main()
        {
            _context = new BlockBusterDbContext();
            _pelicula = new PeliculaService(_context);
        }

        public PeliculaService Peliculas
        {
            get { return _pelicula; }
        }

    }

}