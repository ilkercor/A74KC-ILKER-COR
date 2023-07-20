using INDATAProject.Models;

namespace INDATAProject.Repository
{
    public interface IProductRepository
    {
        void Add<Product>(Product product);
        void Delete<Product>(Product product);
        void Update<Product>(Product product);

        List<Product> GetProducts();
        Product GetProductById(int id);

        void SaveAll();
    }
}
