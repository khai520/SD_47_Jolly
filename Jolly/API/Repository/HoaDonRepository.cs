
using API.Data;
using API.Models;
using API.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace API.Repository
{
    public class HoaDonRepository : IHoaDonRepository
    {
        private readonly DBAppContext _context;

        public HoaDonRepository(DBAppContext context)
        {
            _context = context;
        }

        public async Task UpdateOrderStatus(string orderId, string newStatus, string reason)
        {
            var order = await _context.hoaDons.FindAsync(orderId);
            if (order != null)
            {
                order.TrangThai = newStatus;
                await _context.SaveChangesAsync();

                var history = new LichSuTrangThai
                {
                    HoaDonId = orderId,
                    TrangThai = newStatus,
                    LyDo = reason
                };

                _context.trangThais.Add(history);
                await _context.SaveChangesAsync();
            }
        }
    }
}
