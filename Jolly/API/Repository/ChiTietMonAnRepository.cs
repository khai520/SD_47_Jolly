using API.Data;
using API.Models;
using API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class ChiTietMonAnRepository : Repository<ChiTietMonAn, Guid>, IChiTietMonAnRepository
    {
        private readonly DBAppContext _context;
        public ChiTietMonAnRepository(DBAppContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ChiTietMonAn>> GetMonAnId(string Id)
        {
            return await _context.chiTietMonAns.Where(x => x.MonAnId == Id).ToListAsync();
        }
    }
}
