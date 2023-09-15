using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using thelibrary.Data.enums;
using thelibrary.Helpers;
using static thelibrary.Models.IdentityModel;

namespace thelibrary.Map
{
    public class RoleClaimMap : IEntityTypeConfiguration<RoleClaims>
    {
        private static int counter = 0;
        public void Configure(EntityTypeBuilder<RoleClaims> builder)
        {
            builder.ToTable(nameof(RoleClaims));
            builder.HasKey(p => p.Id);
            SetupData(builder);
        }
        private void SetupData(EntityTypeBuilder<RoleClaims> builder)
        {
            var roleDictionary = new Dictionary<string, Guid>()
            {

                { RoleHelper.ADMIN, RoleHelper.ADMIN_ID() },

            };

            var permissions = (Permission[])Enum.GetValues(typeof(Permission));

            Array.ForEach(permissions, (p) =>
            {
                if (!string.IsNullOrWhiteSpace(p.GetPermissionCategory()) || roleDictionary.ContainsKey(p.GetPermissionCategory()))
                {
                    builder.HasData(new RoleClaims()
                    {
                        Id = ++counter,
                        RoleId = roleDictionary[p.GetPermissionCategory()],
                        ClaimType = nameof(Permission),
                        ClaimValue = p.ToString(),
                    });
                }
            });
        }
    }
}
