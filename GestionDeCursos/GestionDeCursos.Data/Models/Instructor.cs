using System.ComponentModel.DataAnnotations;

namespace GestionDeCursos.Web.Models
{
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
