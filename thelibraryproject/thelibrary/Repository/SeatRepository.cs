using Microsoft.EntityFrameworkCore;
using thelibrary.Data;
using thelibrary.Models;

namespace thelibrary.Repository
{
    public class SeatRepository : ISeatRepository
    {
        private LibraryDbContext _dbContext;
        public SeatRepository(LibraryDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public bool Add(Seat seat)
        {            
            _dbContext.Add(seat);
            return Save();
        }

        public bool Delete(Seat seat)
        {
            _dbContext.Remove(seat);
            return Save();
        }

        public async Task<IEnumerable<Seat>> GetAllSeat()
        {
            return await _dbContext.Seats.ToListAsync();
        }

        public async Task<Seat> GetSeatById(int Id)
        {
            return await _dbContext.Seats.FirstOrDefaultAsync(x => x.Id == Id);
        }

        public async Task<Seat> GetSeatByPosition(string position)
        {
            return await _dbContext.Seats.FirstOrDefaultAsync(x => x.position == position);
        }

        public bool Save()
        {
            var saved = _dbContext.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool Update(Seat seat)
        {
            _dbContext.Update(seat);
            return Save();
        }
    }
}
