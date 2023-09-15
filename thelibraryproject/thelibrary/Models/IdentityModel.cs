using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace thelibrary.Models
{
    public class IdentityModel
    {
        public class AppUserClaims : IdentityUserClaim<Guid>
        {
        }

        public class AppUserLogins : IdentityUserLogin<Guid>
        {
            [Key]
            [Required]
            public int Id { get; set; }
        }



        public class AppUserRoles : IdentityUserRole<Guid>
        {
        }

        public class RoleClaims : IdentityRoleClaim<Guid>
        {
        }

        public class AppUserTokens : IdentityUserToken<Guid>
        {
        }
    }
}
