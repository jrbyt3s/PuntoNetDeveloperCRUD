using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeCursos.Data.Models
{
    [Table("Instructors", Schema = "Management")]
    public class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Instructor Name")]
        public string? InstructorName { get; set; }

        [Required]
        [StringLength(100)]
        public string? Quealification { get; set; }

        [Required]
        public int Experience { get; set; }
    }
}
