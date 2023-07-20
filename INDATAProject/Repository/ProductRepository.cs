using INDATAProject.Models;

namespace INDATAProject.Repository
{
    public class ProductRepository : IProductRepository
    {
        private DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public void Add<Product>(Product product)
        {
            _context.Add(product);
        }

        public void Delete<Product>(Product product)
        {
            _context.Remove(product);
        }

        public Product GetProductById(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == id);
            return product;
        }

        public List<Product> GetProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public void SaveAll()
        {
            _context.SaveChanges();
        }

        public void Update<Product>(Product product)
        {
            _context.Update(product);
        }
    }
}
