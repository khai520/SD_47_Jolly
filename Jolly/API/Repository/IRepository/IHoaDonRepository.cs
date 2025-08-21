namespace API.Repository.IRepository
{
    public interface IHoaDonRepository 
    {
        Task UpdateOrderStatus(string orderId, string newStatus, string reason);
    }
}
