namespace BusinessLayer.Services.Abstract
{
    public interface ICitiesService
    {
        Task<IEnumerable<T>> GetAll<T>();

        Task Add(string name);

        Task Delete(int id);
    }
}
