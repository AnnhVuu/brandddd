using Shop_ReactApp.Server.Models;
namespace Shop_ReactApp.Server.Reponsitory
{
    public interface IBrandReponsitory
    {
        Task<IEnumerable<Brands>> GetAllAsync();
        Task<Brands> GetByIdAsync(string id);
        Task AddAsync(Brands brands);
        Task UpdateAsync(Brands brands);
        Task DeleteAsync(string id);
    }
}
