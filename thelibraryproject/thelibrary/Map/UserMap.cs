using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using thelibrary.Models;

namespace thelibrary.Map
{
    public class UserMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable(name: nameof(Users));
            SetupUser(builder);
            SetupAdmin(builder);
        }

        public PasswordHasher<Users> Hasher { get; set; } = new PasswordHasher<Users>();

        private void SetupUser(EntityTypeBuilder<Users> builder)
        {
            var sysUser = new Users
            {
                Id = Defaults.UserId,
                Email = Defaults.UserEmail,
                PhoneNumber = Defaults.UserMobile,
                PasswordHash = Hasher.HashPassword(null, "Orezi_1608"),
                SecurityStamp = "17C89032-4965-4DCF-9DCF-B9F697D88820"
            };
            builder.HasData(sysUser);


        }
        private void SetupAdmin(EntityTypeBuilder<Users> builder)
        {
            var adminUser = new Users
            {
                Activated = true,
                CreatedOn = new DateTime(2023, 08, 26),
                Name = "Admin",
                Id = Defaults.AdminId,
                LastLoginDate = new DateTime(2023, 08, 26),
                Email = Defaults.AdminEmail,
                EmailConfirmed = true,
                NormalizedEmail = Defaults.AdminEmail.ToUpper(),
                PhoneNumber = Defaults.AdminMobile,
                UserName = Defaults.AdminEmail,
                NormalizedUserName = Defaults.AdminEmail.ToUpper(),
                TwoFactorEnabled = false,
                PhoneNumberConfirmed = true,
                PasswordHash = Hasher.HashPassword(null, "Bolu_1608"),
                SecurityStamp = "D21796E5-9EE1-4868-B217-C2E94B22CD22",
            };
            builder.HasData(adminUser);
        }
    }
}
