using Microsoft.EntityFrameworkCore;
using thelibrary.Models;

namespace thelibrary.Data
{
    public class LibraryDbContext : DbContext
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
        public DbSet<Seat> Seats { get; set; }
        public DbSet<SeatReservation> SeatReservations { get; set; }

       }
}
