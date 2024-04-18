using Microsoft.EntityFrameworkCore;
using Shop_ReactApp.Server.Models;
using Shop_ReactApp.Server.Reponsitory;
namespace Shop_ReactApp.Server.Reponsitory
{

    public class BrandRepository : IBrandReponsitory
    {
        private readonly DataWeb _context;
        public BrandRepository(DataWeb context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Brands>> GetAllAsync()
        {
            return await _context.Brands.ToListAsync();
        }
        public async Task<Brands> GetByIdAsync(string id)
        {
            return await _context.Brands.FindAsync(id);
        }
        public async Task AddAsync(Brands brands)
        {
            _context.Brands.Add(brands);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Brands brands)
        {
            _context.Entry(brands).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(string id)
        {
            var brand = await _context.Brands.FindAsync(id);
            if (brand != null)
            {
                _context.Brands.Remove(brand);
                await _context.SaveChangesAsync();
            }
        }


    }
}
