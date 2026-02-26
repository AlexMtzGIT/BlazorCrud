using System.ComponentModel.DataAnnotations;

namespace BlazorCrud.Modelos
{
    public class Libro
    {
        [Key] //este atributo indica que esta propiedad es la clave primaria de la entidad
        public int Id { get; set; }

        [Required(ErrorMessage = "El titulo es obligatorio")]
        public string Titulo { get; set; }//este atributo indica que esta propiedad es obligatoria y proporciona un mensaje de error personalizado si no se cumple la validación
        //la propiedad Titulo es de tipo string y representa el título del libro. Al marcarla con el atributo [Required], se asegura que esta propiedad no pueda ser nula o vacía al momento de validar el modelo.

        [Required(ErrorMessage = "La Descripción es obligatorio")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "El Autor es obligatorio")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "La Cantidad de paginas es obligatorio")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "El Precio es obligatorio")]
        public int Precio { get; set; }

        public DateTime FechaCreacion { get; set; }
    }
}
