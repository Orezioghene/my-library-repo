using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using thelibrary.Data.enums;
using thelibrary.Model;
using thelibrary.Utilities;

namespace thelibrary.Models
{
    public class Users:IdentityUser<Guid>,IEntity
    {
        public Users()
        {
            Id = SequentialGuidGenerator.Instance.Create();
            CreatedOn = DateTime.UtcNow;
        }
        public string? Name { get; set; }
        public string? Department { get; set; }
        public usertype UserType { get; set; }
        //public string? Matric_No { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public bool Activated { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public string? CreatedBy { get; set; }
        public string? ModifiedBy { get; set; }
        public string? DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }
        public bool IsPasswordDefault { get; set; }

        //relationships
        public ICollection<Recommendation> Recommendations { get; set; }        
        public ICollection<BorrowBook> BookBorrowers { get; set; }
        public ICollection<BookReservation> BookReservations { get; set; }
        
    }
}
