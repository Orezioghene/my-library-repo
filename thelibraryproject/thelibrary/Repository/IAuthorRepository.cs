using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public interface IAuthorRepository
    {

        Task<IEnumerable<Author>> GetAuthors();

        Task<Author> GetAuthorByName(string name);
        Task<Author> GetById(int Id);

        bool Add(Author author);
        bool Delete(Author author);
        bool Update(Author author);
        bool Save();


    }
}
