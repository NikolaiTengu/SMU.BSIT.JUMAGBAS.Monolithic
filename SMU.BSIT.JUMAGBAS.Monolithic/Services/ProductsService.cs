﻿using Microsoft.AspNetCore.Mvc;
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

        public IEnumerable<Product> GetProducts()
        {
            return db.Table<Product>();
        }

        public Product GetProduct(int id)
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
