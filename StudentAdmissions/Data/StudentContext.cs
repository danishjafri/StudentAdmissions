#nullable disable
using Microsoft.EntityFrameworkCore;

public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<StudentAdmissions.Models.Student> Student { get; set; }
    }
