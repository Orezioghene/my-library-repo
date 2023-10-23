using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public class ReviewRepository
    {
        private LibraryDbContext _dbContext;
        public ReviewRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}