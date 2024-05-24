using Microsoft.EntityFrameworkCore;

namespace TesteApi
{
    public class ItemRepository(ApiContext context) : IItemRepository
    {
        private readonly ApiContext _context = context;

        public async Task<IEnumerable<Item>> GetAll()
        {
            return await _context.Items.ToListAsync();
        }

        public async Task<Item> GetById(int id)
        {
            return await _context.Items.FindAsync(id);
        }
    }
}
