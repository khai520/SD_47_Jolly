using JollyWeb.Service.IService;
using API.Repository.IRepository;

namespace JollyWeb.Service
{
    public class HoaDonService : IHoaDonService
    {
        private readonly IHoaDonRepository hoaDonRepository;

        public HoaDonService(IHoaDonRepository hoaDonRepository)
        {
            this.hoaDonRepository = hoaDonRepository;
        }

        public async Task<bool> LichSuTrangThai(string orderId, string newStatus, string reason)
        {
            try
            {
                await hoaDonRepository.UpdateOrderStatus(orderId, newStatus, reason);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
