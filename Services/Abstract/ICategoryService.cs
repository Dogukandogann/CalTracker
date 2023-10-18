namespace Services.Abstract
{
    public interface ICategoryService
    {
        IEnumerable<string> GetCategoryNames();
    }
}