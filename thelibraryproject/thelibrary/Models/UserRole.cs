using Microsoft.AspNetCore.Identity;
using thelibrary.Model;

namespace thelibrary.Models
{
    public class UserRole:IdentityRole<Guid>,IEntity
    {
        public UserRole()
        {
            Id = Guid.NewGuid();
            ConcurrencyStamp = Guid.NewGuid().ToString("N");
        }

        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public Guid? CreatedBy { get; set; }
        public Guid? ModifiedBy { get; set; }
        public bool? IsInBuilt { get; set; } = true;

    }
}
