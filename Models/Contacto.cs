using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace urban_leo.Models
{
    [Table("t_contacto")]
    public class Contacto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set;}
        public string? Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public string? Phone { get; set; }
    }
}