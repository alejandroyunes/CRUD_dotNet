
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace student.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Campo obligatorio.")]
        [DisplayName("Usuario")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Campo obligatorio.")]
        [DisplayName("Nombre")]
        public string FirstName { get; set; }

        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "Campo obligatorio.")]
        [DisplayName("Apellido")]
        public string LastName { get; set; }

        [Column(TypeName = "varchar(10)")]
        [DisplayName("Edad")]
        public string Age { get; set; }

        [Column(TypeName = "varchar(100)")]
        [DisplayName("Carrera")]
        public string Career { get; set; }


    }
}



