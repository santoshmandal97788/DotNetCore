using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [NotMapped]
        public string EncryptedId { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage="Name Cannot exceed 50 character")]
        public string Name { get; set; }
       
        [Required]
        public Dept? Department { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@([a-zA-Z0-9_\-\.]+)\.([a-zA-Z]{2,5})$", ErrorMessage ="Invalid Email")]
        [Display(Name="Office Email")]
        public string Email { get; set; }
        public string PhotoPath { get; set; }
    }
}
