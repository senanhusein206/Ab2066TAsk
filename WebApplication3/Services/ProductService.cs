using WebApplication3.Contexts;
using WebApplication3.Models;

namespace WebApplication3.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        public ProductService()
        {
            _context = new AppDbContext();
        }
        public void CreateProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public Product GetProductById(int id)
        {
            Product? product = _context.Products.Find(id);
            if (product is null)
            {
                throw new Exception("sahagfdsb");
            }
            return product;
        }
        public List<Product> GetAllProducts()
        {
            List<Product> prouducts= _context.Products.ToList();
            return prouducts;
        }

        public void Delete (int id)
        {
            var product = _context.Products.Find(id);
            if (product is null)
            {
                throw new Exception("sahagfdsb");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();

        }

        public void Update(int id,Product p) {

            Product? product = _context.Products.Find(id);
            if (product is null)
            {
                throw new Exception("sahagfdsb");
            }

            product.Price = p.Price;
            product.Name = p.Name;
            product.Descriptins = p.Descriptins;
            _context.SaveChanges();

        }
    }
}
