using System.ComponentModel.DataAnnotations;

namespace DirectorioDeProductos.Models
{
    public class Producto
    {
         public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
         public string Nombre { get; set; }
        [Required(ErrorMessage ="El precio es invalido")]
        public decimal Precio { get; set; }
        [Required(ErrorMessage = "La categoría es obligatoria")]
        public string Categoria { get; set; }

    }
}
