using SQLite;

namespace SMU.BSIT.Jumagbas.Monolithic.ProductsDAL
{
    public class ProductRepositorys
    {
        private string dbPath =>
            Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
            "Products.db");
        private readonly ISQLiteConnection db;

        public ProductRepository()
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<ProductModel>();
        }

        public void AddProduct(ProductModel product)
        {
            db.Insert(product);
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return db.Table<ProductModel>();
        }

        public ProductModel GetProduct(int id)
        {
            try
            {
                var product = GetProducts().Where(q => q.Id.Equals(id)).First();
                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
