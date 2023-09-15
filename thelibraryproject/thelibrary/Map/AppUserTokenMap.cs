using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static thelibrary.Models.IdentityModel;

namespace thelibrary.Map
{
    public class AppUserTokenMap : IEntityTypeConfiguration<AppUserTokens>
    {
        public void Configure(EntityTypeBuilder<AppUserTokens> builder)
        {
            builder.ToTable(nameof(AppUserTokenMap));
            builder.HasKey(b => b.UserId);
        }
    }
}
