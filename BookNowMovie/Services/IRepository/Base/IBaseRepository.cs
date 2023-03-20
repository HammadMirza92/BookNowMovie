using BookNowMovie.Models;

namespace BookNowMovie.Services.IRepository.Base
{
    public interface IBaseRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<T> Add(T entity);
        public void Delete(int id);
        public Task Update(T entity);
    }
}
