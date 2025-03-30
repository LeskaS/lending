﻿using Azure;
using lending_skills_backend.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace lending_skills_backend.DataAccess;

public class ApplicationDbContext : DbContext
{
    private readonly IConfiguration _configuration;
    public ApplicationDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public DbSet<DbUser> Users { get; set; }
    public DbSet<DbProgram> Programs { get; set; }
    //public DbSet<DbReview> Reviews { get; set; }
    //public DbSet<DbProfessor> Professors { get; set; }
    public DbSet<DbWork> Works { get; set; }
    public DbSet<DbLike> Likes { get; set; }
    public DbSet<DbPage> Pages { get; set; }
    public DbSet<DbBlock> Blocks { get; set; }
    public DbSet<DbForm> Forms { get; set; }
    public DbSet<DbToken> Tokens { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Database"));
    }

}