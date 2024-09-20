using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeCursos.Data.Models
{
    [Table("Courses", Schema = "Management")]
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Course")]
        public string? CourseName { get; set; }

        [StringLength(250)]
        [Display(Name ="Description")]
        public string? CourseDescription { get; set; }

    }
}
