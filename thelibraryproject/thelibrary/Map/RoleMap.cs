using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using thelibrary.Helpers;
using thelibrary.Models;

namespace thelibrary.Map
{
    public class RoleMap : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable(name: nameof(UserRole));
            SetupData(builder);
        }

        private static void SetupData(EntityTypeBuilder<UserRole> builder)
        {
            var roles = new UserRole[]
            {               
                new UserRole
                {
                    Id = RoleHelper.ADMIN_ID(),
                    Name = RoleHelper.ADMIN,
                    NormalizedName = RoleHelper.ADMIN.ToString()
                },
                new UserRole
                {
                    Id = RoleHelper.USER_ID(),
                    Name = RoleHelper.USER,
                    NormalizedName = RoleHelper.USER.ToString()
                },

            };

            builder.HasData(roles);
        }
    }
}
