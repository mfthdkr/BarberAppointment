namespace BusinessLayer.Services.Abstract
{
    public interface IBarbersService
    {
        Task<IEnumerable<T>> GetAll<T>();
        Task<IEnumerable<T>> GetAllForPaging<T>(int pageSize,int pageIndex);
        Task<int> GetCountForPagination();
        Task<T> GetById<T>(int id);
        Task Add(string name, int cityId, string address, string imageUrl);
        Task Delete(int id);
        Task RateSalon(int id, int rateValue);
    }
}
