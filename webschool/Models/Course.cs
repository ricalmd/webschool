using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webschool.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [Display(Name = "Nome do Curso")]
        [Required(ErrorMessage = "Tem que inserir um nome")]
        [StringLength(50, ErrorMessage = "O {0} deverá ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "Área")]
        [Required(ErrorMessage = "Tem que indicar a área")]
        [StringLength(30, ErrorMessage = "A {0} deverá ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Field { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        [Display(Name = "Horário - Início")]
        public DateTime ScheduleBegin { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = false)]
        [Display(Name = "Horário - Fim")]
        public DateTime ScheduleEnd { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Calendário - Início")]
        public DateTime CalendarBegin { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Calendário - Fim")]
        public DateTime CalendarEnd { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Tem que fornecer uma descrição")]
        [StringLength(255, ErrorMessage = "A {0} deverá ter entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}