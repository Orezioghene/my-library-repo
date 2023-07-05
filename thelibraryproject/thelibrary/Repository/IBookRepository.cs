using thelibrary.Models;

namespace thelibrary.Repository
{
    public interface IBookRepository
    {
         Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookById(int Id);
        //    Task<Book> GetBookByName(string name);
        //    Task<Book> GetBookByAuthor (string Author);
        //    Task<Book> GetBookByCategory(string category);


        bool Add(Book book);
        //bool Delete(Book book);
        //bool Update(Book book);
        bool Save();
    }
}
