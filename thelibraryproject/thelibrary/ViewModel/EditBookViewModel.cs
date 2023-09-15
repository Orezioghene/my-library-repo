using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using thelibrary.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace thelibrary.Models
{
    public class EditBookViewModel
    {
        //[Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string BookSummary { get; set; }
        public IFormFile ActualBook { get; set; }
        public string? URL { get; set; }
       
        public int CategoryId { get; set; }
        



       
    }
}
