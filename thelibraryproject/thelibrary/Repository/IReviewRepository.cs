using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public interface IReviewRepository
    {
        Task<IEnumerable<Recommendation>> GetAllRecommendations();

        bool Add(Recommendation review);
        bool Delete(Recommendation review);
        bool Update(Recommendation review);
        bool Save();
    }
}
