using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using EmployeeCrud.Models.Enums;
using System.ComponentModel;

namespace EmployeeCrud.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("First name")]
        public string? FName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Last name")]
        public string? LName { get; set; }
        public GenderEnum? Gender { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Column(TypeName = "nvarchar(80)")]
        public string? Email { get; set; } = null!;

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        [DisplayName("Date of birth")]
        public DateTime Dob { get; set; }
        [Display(Name = "Student")]
        public bool isStudent { get; set; } = false; // Checkbox
        [Display(Name = "Full time")]
        public bool isFulltime { get; set; } = false; // Checkbox
        [Display(Name = "Still work here?")]
        public bool Active { get; set; } = false;  // Radio Yes/No

        public string? Note { get; set; }
    }
}
