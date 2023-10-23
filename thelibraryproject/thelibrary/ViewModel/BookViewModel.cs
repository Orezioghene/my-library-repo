using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using thelibrary.Models;

namespace thelibrary.ViewModel
{
    public class BookViewModel
    {
        
        //categoryid
        public int Id { get; set; }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string BookSummary { get; set; }
        public IFormFile ActualBook { get; set; }
        public int CategoryId { get;set; }
        
        public List<int>? AuthorId { get; set; }
       

        public static explicit operator BookViewModel(Book source)
        {
            var destination = new BookViewModel()
            {
                Id = source.Id,
                Title = source.Title,
                BookSummary = source.BookSummary,
                CategoryId = source.CategoryId,
                

            };
            return destination;
        }

    }
}
