using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lending_skills_backend.Models;

public class DbBlock
{
    public const string TableName = "Blocks";
    public Guid Id { get; set; }

    public string Date { get; set; }
    public string IsExample { get; set; }
    public int Type { get; set; }
    public string NextBlockId { get; set; }
    public string PreviousBlockId { get; set; }

    public DbForm Forms { get; set; }


    //public ICollection<DbForm> Forms { get; set; } = new List<DbForm>();
    public ICollection<DbPage> Pages { get; set; } = new List<DbPage>();
}


public class DbBlocksConfiguration : IEntityTypeConfiguration<DbBlock>
{
    public void Configure(EntityTypeBuilder<DbBlock> builder)
    {
        builder
            .ToTable(DbBlock.TableName);

        builder
            .HasKey(b => b.Id);

        builder.HasMany(b => b.Pages)
            .WithMany(p => p.Blocks);


        builder.HasOne(b => b.Forms)
            .WithOne(p => p.Blocks)
            .HasForeignKey<DbForm>(f => f.BlockId)
            .OnDelete(DeleteBehavior.NoAction);

    }

}
