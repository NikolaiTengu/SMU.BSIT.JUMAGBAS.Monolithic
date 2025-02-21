using SMU.BSIT.JUMAGBAS.Monolithic.Models;
using SQLite;


namespace SMU.BSIT.JUMAGBAS.Monolithic.Services
{
    public class ProductsService
    {
        private string dbPath =>
            Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments),
            "Products.db");
        private readonly ISQLiteConnection db;

        public ProductsService()
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Product>();
        }

        public void AddProduct(Product product)
        {
            db.Insert(product);
        }
    }
}
