using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;

namespace WebAppSample.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options)
        {

        }
        public DbSet<School> Schools { get; set; }
    }
}
