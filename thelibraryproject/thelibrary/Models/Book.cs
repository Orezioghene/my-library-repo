using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using thelibrary.ViewModel;

namespace thelibrary.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
        public int Pages { get; set; }
        public string BookSummary { get; set; }
        public string ActualBook { get; set; }
        
        
        //public string DeletedBy { get; set; } = string.Empty;
        //public bool IsDeleted { get; set; }
        //public DateTime? DeletedOn { get; set; }
        //public DateTime CreatedOn { get; set; }
        //public DateTime? ModifiedOn { get; set; }

        //public string CreatedBy { get; set; } = string.Empty;
        //public string ModifiedBy { get; set; } = string.Empty;


        [ForeignKey("Category")]
        //category
        public int CategoryId { get; set; }
        //public string CategoryName { get; set; }

        public Category Category { get; set; }



        //[NotMapped]
        //public List<SelectListItem> CatgoryList { get; set; }

        //recommendations

        public ICollection<Recommendation> Recommendations { get; set; }
        //Author
        public ICollection<BookAuthor> BookAuthors { get; set; }
        //Borrow book
        public ICollection<BorrowBook> BookBorrowers { get; set; }

        public ICollection<BookReservation> BookReservations { get; set; }


        




    }
}
