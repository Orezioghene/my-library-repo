using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using static thelibrary.Models.IdentityModel;

namespace thelibrary.Map
{
    public class UserLoginMap : IEntityTypeConfiguration<AppUserLogins>
    {
        public void Configure(EntityTypeBuilder<AppUserLogins> builder)
        {
            builder.ToTable(nameof(AppUserLogins));
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
            builder.HasKey(u => new { u.LoginProvider, u.ProviderKey });
        }
    }
}
