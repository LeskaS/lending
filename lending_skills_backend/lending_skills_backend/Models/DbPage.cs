using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lending_skills_backend.Models;

public class DbPage
{
    public const string TableName = "Pages";
    public Guid Id { get; set; }

    public Guid ProgramId { get; set; }
    public Guid BlocksId { get; set; }

    //public DbBlock Blocks { get; set; }

    //public DbProgram Programs { get; set; }

    public ICollection<DbProgram> Programs { get; set; } = new List<DbProgram>();
    public ICollection<DbBlock> Blocks { get; set; } = new List<DbBlock>();
}


public class DbPagesConfiguration : IEntityTypeConfiguration<DbPage>
{
    public void Configure(EntityTypeBuilder<DbPage> builder)
    {
        builder
            .ToTable(DbPage.TableName);

        builder
            .HasKey(pg => pg.Id);

        builder.HasMany(pg => pg.Programs)  // Указываем, что DbPage может быть связан с одним Program
            .WithMany(p => p.Pages);  // Связь с коллекцией Pages в DbProgram

        builder.HasMany(p => p.Blocks)
            .WithMany(b => b.Pages);

    }

}
