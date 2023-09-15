using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static thelibrary.Models.IdentityModel;

namespace thelibrary.Map
{
    public class UserClaimMap : IEntityTypeConfiguration<AppUserClaims>
    {
        public void Configure(EntityTypeBuilder<AppUserClaims> builder)
        {
            builder.ToTable(nameof(AppUserClaims));
            builder.HasKey(c => c.Id);
        }
    }
}

