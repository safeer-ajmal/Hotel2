namespace Hotel.Application.Interface
{
    public interface  IRepository<T> where T : class

    {
         Task<T> GetHotelById(int id);
         Task<IEnumerable<T>> GetAllHotels();
         Task<T> AddHotel(T entity);
         Task<T> UpdateHotel(T entity);
         Task<bool> DeleteHotel(int id);
         Task<bool> SaveChangesAsync();

    }
}
