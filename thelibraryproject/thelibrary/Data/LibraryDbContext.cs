using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using thelibrary.Map;
using thelibrary.Models;
using static thelibrary.Models.IdentityModel;

namespace thelibrary.Data
{
    public class LibraryDbContext : IdentityDbContext<Users, UserRole,Guid, AppUserClaims, AppUserRoles, AppUserLogins, RoleClaims,AppUserTokens >
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {

        }


        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BorrowBook> Booksborrowed { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }             
        public DbSet<BookReservation> BookReservations { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatReservation> SeatReservation { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserMap());
            builder.ApplyConfiguration(new RoleMap());
            builder.ApplyConfiguration(new UserClaimMap());
            builder.ApplyConfiguration(new RoleClaimMap());
            builder.ApplyConfiguration(new UserLoginMap());
            builder.ApplyConfiguration(new UserRoleMap());
            builder.ApplyConfiguration(new AppUserTokenMap());

        }

    }
}
