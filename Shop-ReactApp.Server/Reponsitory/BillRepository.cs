using Microsoft.EntityFrameworkCore;
using Shop_ReactApp.Server.Models;
using Shop_ReactApp.Server.Reponsitory;
namespace Shop_ReactApp.Server.Reponsitory
{

    public class BillRepository : IBillReponsitory
    {
        private readonly DataWeb _context;
        public BillRepository(DataWeb context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Bills>> GetAllAsync()
        {
            return await _context.Bills.ToListAsync();
        }
        public async Task<Bills> GetByIdAsync(string id)
        {
            return await _context.Bills.FindAsync(id);
        }
        public async Task AddAsync(Bills bill)
        {
            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateAsync(Bills product)
        {
            _context.Entry(product).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(string id)
        {
            var product = await _context.Bills.FindAsync(id);
            if (product != null)
            {
                _context.Bills.Remove(product);
                await _context.SaveChangesAsync();
            }
        }

        
    }
}
