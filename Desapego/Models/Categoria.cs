using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Principal;

namespace Desapego.Models
{
    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Estado Obrigatório.")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Modelo Obrigatório.")]
        public int Modelo { get; set; }

    }
}
