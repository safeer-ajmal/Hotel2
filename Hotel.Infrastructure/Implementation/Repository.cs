using Hotel.Application.Interface;
using Microsoft.EntityFrameworkCore;
namespace Hotel.Infrastructure.Implementation
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public Task<T> AddHotel(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetHotelById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateHotel(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
