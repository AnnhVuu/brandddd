using Shop_ReactApp.Server.Models;
namespace Shop_ReactApp.Server.Reponsitory
{
    public interface IBillReponsitory
    {
        Task<IEnumerable<Bills>> GetAllAsync();
        Task<Bills> GetByIdAsync(string id);
        Task AddAsync(Bills product);
        Task UpdateAsync(Bills product);
        Task DeleteAsync(string id);
    }
}
