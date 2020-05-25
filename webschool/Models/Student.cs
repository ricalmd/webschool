using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webschool.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [Display(Name = "Nome Completo")]
        [Required(ErrorMessage = "Tem que inserir o nome")]
        [StringLength(50, ErrorMessage = "O {0} deverá ter entre {2} e {1} caracteres", MinimumLength = 8)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Tem que inserir o {0}")]
        [StringLength(9, ErrorMessage = "O {0} deverá ter {2} caracteres", MinimumLength = 9)]
        public string NIF { get; set; }

        [Required(ErrorMessage = "Tem que inserir a {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Cartão de Cidadão")]
        [Required(ErrorMessage = "Tem que inserir o {0}")]
        [StringLength(9, ErrorMessage = "O {0} deverá ter {2} caracteres", MinimumLength = 9)]
        public string CC { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Tem que inserir o {0}")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(30, ErrorMessage = "O {0} deverá ter entre {2} e {1} caracteres", MinimumLength = 9)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Tem que inserir o {0}")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Escolha uma opção")]
        public string Gender { get; set; }

        [Display(Name = "Morada")]
        [Required(ErrorMessage = "Tem que inserir a {0}")]
        [StringLength(100, ErrorMessage = "A {0} deverá ter entre {2} e {1} caracteres", MinimumLength = 5)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Tem que inserir o {0}")]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Código Postal")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Tem que inserir o {0}")]
        [StringLength(25, ErrorMessage = "O {0} deverá ter {2} caracteres", MinimumLength = 25)]
        public string IBAN { get; set; }

        [Required(ErrorMessage = "Tem que inserir a {0}")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = false)]
        [Display(Name = "Data de Ingresso")]
        public DateTime AdmissionDay { get; set; }

        [Required(ErrorMessage = "Deve escolher um curso")]
        [Range(1, double.MaxValue, ErrorMessage = "Tem que selecionar um curso")]
        [Display(Name = "Cursos")]
        public int CourseID { get; set; }

        public virtual Course Course { get; set; }
    }
}