public interface ISearchable
{
    List<Product> SearchByPrice(List<Product> products, double minPrice, double maxPrice);
    List<Product> SearchByCategory(List<Product> products, string category);
    List<Product> SearchByRating(List<Product> products, double minRating);
}
