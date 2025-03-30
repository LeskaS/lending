using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace lending_skills_backend.Models;

public class DbProgram
{
    public const string TableName = "Programs";

    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Menu { get; set; } //json?

    public Guid? PageId { get; set; }
    //public DbPage? Pages { get; set; }

    public ICollection<DbPage> Pages { get; set; } = new List<DbPage>();
}

public class DbProgramConfiguration : IEntityTypeConfiguration<DbProgram>
{
    public void Configure(EntityTypeBuilder<DbProgram> builder)
    {
        builder.ToTable(DbProgram.TableName);

        builder.HasKey(p => p.Id);

        builder.HasMany(p => p.Pages)  // Связь один ко многим (Program -> Pages)
                   .WithMany(pg => pg.Programs); // Сторона с DbPage
    }
}
