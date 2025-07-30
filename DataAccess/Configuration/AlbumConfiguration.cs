using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    internal class AlbumConfiguration : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("cdAlbum").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("uniqueidentifier").HasDefaultValueSql("(newid())");
            builder.Property(x => x.UserId).HasColumnType("uniqueidentifier");
            builder.Property(x => x.AlbumName).HasColumnType("nvarchar(1000)").HasDefaultValueSql("(N'')");
            builder.Property(x => x.StartedDate).HasColumnType("datetime");
            builder.Property(x => x.EndDate).HasColumnType("datetime");
            builder.Property(x => x.PhotographerNote).HasColumnType("nvarchar(MAX)").HasDefaultValueSql("(N'')");
            builder.Property(x => x.Note).HasColumnType("nvarchar(MAX)").HasDefaultValueSql("(N'')");
            builder.Property(x => x.SelectedCount).HasColumnType("int").HasDefaultValueSql("((0))");
            builder.Property(x => x.IsDraft).HasColumnType("bit").HasDefaultValueSql("((0))");
            builder.Property(x => x.IsSend).HasColumnType("bit").HasDefaultValueSql("((0))");
            builder.Property(x => x.IsViewed).HasColumnType("bit").HasDefaultValueSql("((0))");
            builder.Property(x => x.IsProcessed).HasColumnType("bit").HasDefaultValueSql("((0))");
            builder.Property(x => x.IsCompleted).HasColumnType("bit").HasDefaultValueSql("((0))");
        }
    }
}
