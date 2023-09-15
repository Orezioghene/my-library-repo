using thelibrary.Models;
using thelibrary.ViewModel;

namespace thelibrary.Repository
{
    public interface ISeatRepository
    {
        Task<IEnumerable<Seat>> GetAllSeat();

        Task<Seat> GetSeatByPosition(string position);
        Task<Seat> GetSeatById(int Id);

        bool Add(Seat seat);
        bool Delete(Seat seat);
        bool Update(Seat seat);
        bool Save();
    }
}
