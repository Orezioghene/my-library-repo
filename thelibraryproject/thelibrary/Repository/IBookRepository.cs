using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Task<Book> GetBookById(int Id);
        Task<Book> GetBookByName(string Title);
        //Task<Book> GetBookByIdNoTracking(int Id);
        //    Task<Book> GetBookByAuthor (string Author);
        //    Task<Book> GetBookByCategory(string category);


        bool Add(Book book);
        bool Delete(Book book);
        bool Update(Book book);
        bool Save();
    }
}
