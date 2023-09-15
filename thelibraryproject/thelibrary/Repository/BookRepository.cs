using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Map;
using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public class BookRepository : IBookRepository
    {
       
        private readonly LibraryDbContext _dbContext;

        public BookRepository(LibraryDbContext dbContext)
        {
            _dbContext = dbContext;           

        }
      

        public bool Add(Book book)
        {
            _dbContext.Add(book);
            return Save();
        }

        public bool Delete(Book book)
        {
            _dbContext.Remove(book);
            return Save();
        }

       
        
        public async Task<Book> GetBookById(int Id)
        {
           return await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == Id);
            
        }

        public async Task<Book> GetBookByIdNoTracking(int Id)
        {
            var getbook = await _dbContext.Books.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Id);
            return getbook;
        }


        public async Task<Book> GetBookByName(string Title)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(x => x.Title == Title);
        }

        public IEnumerable<Book> GetBooks()
        {

            return _dbContext.Books.ToList();
            //var data = (from book in _dbContext.Books join category in _dbContext.Categories
            //            on book.CategoryId equals category.Id
            //            select new Book { Id = book.Id , CategoryId = book.CategoryId,
            //            Title= book.Title, BookSummary = book.BookSummary, ActualBook= book.ActualBook, Pages = book.Pages}).ToList();
            //return data;
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Book book)
        {
            _dbContext.Update(book);
            return Save();
        }

       
    }
}
