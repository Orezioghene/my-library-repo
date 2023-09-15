using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using thelibrary.Helpers;
using static thelibrary.Models.IdentityModel;
using thelibrary.Models;

namespace thelibrary.Map
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRoles>
    {
        public void Configure(EntityTypeBuilder<AppUserRoles> builder)
        {
            builder.ToTable(name: nameof(AppUserRoles));
            builder.HasKey(p => new { p.UserId, p.RoleId });
            SetupData(builder);
        }

        private void SetupData(EntityTypeBuilder<AppUserRoles> builder)
        {
            List<AppUserRoles> dataList = new List<AppUserRoles>()
            {

                 new AppUserRoles()
                {
                    UserId = Defaults.AdminId,
                    RoleId = RoleHelper.ADMIN_ID(),
                },


            };

            builder.HasData(dataList);
        }
    }
}
