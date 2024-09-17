using ecommerce.DataAccess.Repository.IRepository;
using ecommerce.Models;
using ecommerceApp.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.DataAccess.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private ApplicationDbContext _db;

        public ProductImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;

        }

        public void Update(ProductImage obj)
        {
            _db.ProductImages.Add(obj);
        }
    }
}
