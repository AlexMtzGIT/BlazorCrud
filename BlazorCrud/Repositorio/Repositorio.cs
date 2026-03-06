using BlazorCrud.Components.Data;
using BlazorCrud.Modelos;
using Microsoft.EntityFrameworkCore;

namespace BlazorCrud.Repositorio
{
    //esta es la clase que implementa a la interfaz IReposiroty
    public class Repositorio : IRepositorio //para implementarlo primero hay que llamarlo con ": IRepositorio" (el nombre de la interfaz del repositorio)
    {

        private readonly ApplicationDbContext _contexto;

        public Repositorio(ApplicationDbContext contexto)// este es el metodo constructor (es constructor porque tiene el mimso nombre que la clase) de esta clase (Repositorio)
        {
            _contexto = contexto;
        }
        public async Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro)
        {
            var libroDesdeBD = await _contexto.Libro.FindAsync(libroId);
            libroDesdeBD.Titulo = actualizarLibro.Titulo;
            libroDesdeBD.Descripcion = actualizarLibro.Descripcion;
            libroDesdeBD.Autor = actualizarLibro.Autor;
            libroDesdeBD.Paginas = actualizarLibro.Paginas;
            libroDesdeBD.Precio = actualizarLibro.Precio;

            await _contexto.SaveChangesAsync();
            return libroDesdeBD;
            
        }

        public async Task<Libro> CrearLibro(Libro crearLibro)
        {
            if (crearLibro != null)
            {
                crearLibro.FechaCreacion = DateTime.Now;
                await _contexto.Libro.AddAsync(crearLibro);
                await _contexto.SaveChangesAsync();
                return crearLibro;
            }
            else
            {
                return new Libro();
            }
        }

        public async Task EliminarLibro(int libroId)
        {
            var LibroDesdeBd = await _contexto.Libro.FindAsync(libroId);
            _contexto.Remove(LibroDesdeBd);
            await _contexto.SaveChangesAsync();

        }

        public async Task<Libro> GetLibro(int libroId)
        {
            var LibroDesdeBd = await _contexto.Libro.FindAsync(libroId);
            if (LibroDesdeBd == null)
            {
                return new Libro();
            }
            else
            {
                return LibroDesdeBd;
            }
        }

        public Task<List<Libro>> GetLibros()
        {
            return _contexto.Libro.ToListAsync();
        }
    }
}
