using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestionDeCursos.Data.Models
{
    [Table("Students", Schema = "Management")]
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string? StudentName { get; set; }

        [Required]
        [Display(Name = "Course")]
        public int CourseId { get; set; }
        public Course? Course { get; set; }

        [Required]
        [Display(Name = "Instructor")]
        public int InstructorId { get; set; }
        public Instructor? Instructor { get; set; }

        [Required]
        [Display(Name = "Fee")]
        [DataType(DataType.Currency)]
        public int CourseFee { get; set; }

        [Required]
        [Display(Name = "Duration")]
        public int CourseDuration { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime CourseStartDate { get; set; }

        [Required]
        [DataType(DataType.Time)]
        [Display(Name = "Batch Timing")]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm tt}")]
        public DateTime BachTime { get; set; }
    }
}
