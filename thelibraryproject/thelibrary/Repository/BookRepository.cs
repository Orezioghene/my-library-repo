using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;

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
            //var newBook = new Book()
            //{
            //    Title = book.Title,
            //    Pages = book.Pages,
            //    BookSummary = book.BookSummary,
            //    Category = new Category()
            //    {
            //         Name = book.Category.Name,
            //    }
            //};
            _dbContext.Add(book);
            return Save();
        }

        //public bool Delete(Book book)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Book> GetBookByAuthor(string Author)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<Book> GetBookByCategory(string category)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<Book> GetBookById(int Id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public  async Task<IEnumerable<Book>> GetBooks()
        {
            return await _dbContext.Books.ToListAsync();
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        //public bool Update(Book book)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
