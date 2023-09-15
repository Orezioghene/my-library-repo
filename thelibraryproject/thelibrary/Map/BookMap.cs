using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Map
{
    public static class BookMap
    {
        //public static GetBookViewModel Map(this Book model)
        //{
        //    if (model == null)
        //    {
        //        return null;
        //    }
        //    return new GetBookViewModel
        //    {
        //        Id = model.Id,
        //        Title = model.Title,
        //        CategoryId = model.CategoryId,
        //        ActualBook = model.ActualBook,
        //        BookSummary = model.BookSummary,
        //        Pages = model.Pages,


        //    };
        //}

        public static EditBookViewModel Map(this Book model)
        {
            if (model == null)
            {
                return null;
            }
            return new EditBookViewModel
            {
                Id = model.CategoryId,
                Title = model.Title,               
                URL = model.ActualBook,
                BookSummary = model.BookSummary,
                Pages = model.Pages,


            };
        }

        public static Book Mapper(this EditBookViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Book
            {
                Id = model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                ActualBook = model.ActualBook.ToString(),
                BookSummary = model.BookSummary,
                Pages = model.Pages,


            };
        }

        public static EditBookViewModel Mapper(this Book model)
        {
            if (model == null)
            {
                return null;
            }
            return new EditBookViewModel
            {
                Id = model.Id,
                CategoryId = model.CategoryId,
                Title = model.Title,
                URL = model.ActualBook,
                BookSummary = model.BookSummary,
                Pages = model.Pages,


            };
        }



        public static Book Map(this BookViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Book
            {
                Id = model.Id,
                Title = model.Title,
                CategoryId = model.Id,
                ActualBook = model.ActualBook.ToString(),
                BookSummary = model.BookSummary,
                Pages = model.Pages,


            };
        }

        //public static EditBookViewModel Mapper(this Book model)
        //{
        //    if (model == null)
        //    {
        //        return null;
        //    }
        //    return new EditBookViewModel
        //    {
        //        Id = model.Id,
        //        Title = model.Title,
        //        CategoryId = model.CategoryId,
        //        ActualBook = model.ActualBook,
        //        BookSummary = model.BookSummary,
        //        Pages = model.Pages,
        //    };
        //}

        //public static EditBookViewModel Mapper(this BookViewModel model)
        //{
        //    if (model == null)
        //    {
        //        return null;
        //    }
        //    return new EditBookViewModel
        //    {
        //        Id = model.Id,
        //        Title = model.Title,
        //        CategoryId = model.CategoryId,
        //        ActualBook = model.ActualBook.ToString(),
        //        BookSummary = model.BookSummary,
        //        Pages = model.Pages,
        //    };
        //}


    }
}
