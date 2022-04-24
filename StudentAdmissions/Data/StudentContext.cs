﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentAdmissions.Models;

    public class StudentContext : DbContext
    {
        public StudentContext (DbContextOptions<StudentContext> options)
            : base(options)
        {
        }

        public DbSet<StudentAdmissions.Models.Student> Student { get; set; }
    }