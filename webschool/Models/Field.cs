using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webschool.Models
{
    public class Field
    {
        [Key]
        public int FieldID { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}