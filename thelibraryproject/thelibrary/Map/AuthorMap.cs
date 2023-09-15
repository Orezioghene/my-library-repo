using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Map
{
    public static class AuthorMap
    {

        public static Author Map(this AuthorViewModel model)
        {
            if (model == null)
            {
                return null;
            }
            return new Author
            {
                //PictureURL = model.PictureURL.ToString(),
                Name = model.Name,
                Biography = model.Biography,
                Sex = model.Sex


            };
        }
    }
}
