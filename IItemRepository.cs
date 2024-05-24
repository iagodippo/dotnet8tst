namespace TesteApi
{
    public interface IItemRepository
    {
        Task<IEnumerable<Item>> GetAll();
        Task<Item> GetById(int id);
    }
}