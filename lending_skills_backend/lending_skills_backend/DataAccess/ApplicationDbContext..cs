using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using YourProject.Models;

namespace YourProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Token> Tokens { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfessorsPrograms>()
                .HasKey(pp => new { pp.ProgramId, pp.ProfessorId });

            modelBuilder.Entity<Admin>()
                .HasKey(a => new { a.UserId, a.ProgramId });
        }
    }
}