using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class CleanDBContext:DbContext
    {
        public CleanDBContext(DbContextOptions options):base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}
