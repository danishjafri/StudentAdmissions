using System.ComponentModel.DataAnnotations;

namespace StudentAdmissions.Models
{
    public class Student
    {
        public Guid Id { get; set; }
        [MinLength(3)]
        [MaxLength(20)]
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        [Range(18, int.MaxValue, ErrorMessage = "Age cannot be less than 18")]
        public int Age { get; set; }
    }
}
