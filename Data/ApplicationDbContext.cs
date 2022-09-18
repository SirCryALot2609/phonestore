using System;
using Microsoft.EntityFrameworkCore;
using testmvc.Models;
using testmvc.Data;

namespace testmvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<test> tests { get; set; }
    }
}

