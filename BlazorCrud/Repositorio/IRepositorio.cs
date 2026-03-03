using BlazorCrud.Modelos;

namespace BlazorCrud.Repositorio
{
    public interface IRepositorio
    {
        //metodos que tendra esta interfaz
        //"Libro" viene del modelo que creamos en la carpeta Modelos (Libro.cs), de ahi se sacan las propiedades
        public Task<List<Libro>> GetLibros(); //este metodo nos trae la lista de libros que esten en la BD
        public Task<Libro> GetLibro(int libroId); //este metodo nos traera cada libro por su ID
        public Task<Libro> CrearLibro(Libro crearLibro);//este metodo creara un libro
        public Task<Libro> ActualizarLibro(int libroId, Libro actualizarLibro);//este metodo actualizara un libro dependiendo de cual escogamos por su ID
        public Task EliminarLibro(int libroId);//este metodo eliminara un libro al obtener su ID
    }
}
