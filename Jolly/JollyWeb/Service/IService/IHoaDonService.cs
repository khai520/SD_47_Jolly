namespace JollyWeb.Service.IService
{
    public interface IHoaDonService
    {
        Task<bool> LichSuTrangThai(string orderId, string newStatus, string reason);
    }
}
