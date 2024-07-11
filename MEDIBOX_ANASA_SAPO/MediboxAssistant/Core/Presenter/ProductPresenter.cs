using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Medibox.Database;
using Medibox.Model;
using Sanita.Utility.Database.BaseDao;
using Sanita.Utility.Database.Utility;
using Sanita.Utility.ExtendedThread;

namespace Medibox.Presenter
{
    public class ProductPresenter : BasePresenter
    {
        private const String TAG = "ProductPresenter";
        public static IList<Product> GetProducts()
        {
            return ProductDB.mInstance.GetProducts(null,null);
        }

        public static Product GetProduct()
        {
            return ProductDB.mInstance.GetProduct();
        }

        public static Product GetProduct(int id)
        {
            return ProductDB.mInstance.GetProduct(id);
        }

        public static Product GetProductbyID(int product_id)
        {
            return ProductDB.mInstance.GetProductbyID(product_id);
        }

        public static void UpdateProduct(Product data)
        {
            ProductDB.mInstance.UpdateProduct(null, null, data);
        }

        public static void InsertProduct(Product data)
        {
            ProductDB.mInstance.InsertProduct(null, null, data);
        }

        public static int DeleteProduct(Product data)
        {
            return ProductDB.mInstance.DeleteProduct(data);
        }
    }
}
