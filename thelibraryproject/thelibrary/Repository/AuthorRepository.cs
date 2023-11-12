using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private LibraryDbContext _dbContext;
       
        //private readonly IConfiguration _config;

        public AuthorRepository( LibraryDbContext dbContext)
        {
            
            _dbContext = dbContext;
           
        }

        public bool Add(Author author)
        {
            //var newAuthor = new Author()
            //{
            //    Name = author.Name,
            //    Biography = author.Biography,
            //    PictureURL = author.URL,
            //    Sex = author.Sex,
            //};
            _dbContext.Add(author);
            return Save();
        }

        public bool Delete(Author author)
        {
            _dbContext.Remove(author);
            return Save();
        }

        public async Task<Author> GetAuthorByName(string name)
        {
            return await _dbContext.Authors.FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await _dbContext.Authors.ToListAsync();


        }

        public async Task<Author> GetById(int Id)
        {
            return await _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();  
            return saved > 0 ? true : false;
        }

        public bool Update(Author author)
        {
           _dbContext.Update(author);
            return Save();
        }
    }
}
 