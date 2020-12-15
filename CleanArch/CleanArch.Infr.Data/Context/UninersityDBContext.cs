using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infr.Data.Context
{
    public class UninersityDBContext : DbContext
    {
        public UninersityDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
