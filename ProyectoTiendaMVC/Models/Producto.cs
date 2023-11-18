using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProyectoTiendaMVC.Models
{
    public class Producto
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public decimal Precio { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaCreacion { get; set; }

        [EnumDataType(typeof(Categoria))]
        public Categoria categoria { get; set; }
    }
}
