using SMU.BSIT.Jumagbas.Monolithic.ProductsDAL;

namespace SMU.BSIT.Jumagbas.Monolithic.ProductsBLL

{
    public class ProductService
    {
        ProductRepository productRepository = new ProductRepository();

        public void AddProduct(ProductDTO product)
        {
           ProductModel model = new ProductModel
           {
               Id = product.Id,
               Name = product.Name,
               Type = product.Type,
               Manufacturer = product.Manufacturer
           };

            if (product != null)
            {
                productRepository.AddProduct(product);
            }
            else
            {
                throw new ArgumentNullException("Product is null");
            }
        }
    }
}
