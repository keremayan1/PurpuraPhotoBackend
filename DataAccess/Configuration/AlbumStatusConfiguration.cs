using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configuration
{
    public class AlbumStatusConfiguration : IEntityTypeConfiguration<AlbumStatus>
    {
        public void Configure(EntityTypeBuilder<AlbumStatus> builder)
        {
            builder.ToTable("bsAlbumStatus").HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnType("uniqueidentifier").HasDefaultValueSql("(newid())");
            builder.Property(x => x.AlbumStatusName).HasColumnType("nvarchar(50)").HasDefaultValueSql("(N'')");
        }
    }
}
