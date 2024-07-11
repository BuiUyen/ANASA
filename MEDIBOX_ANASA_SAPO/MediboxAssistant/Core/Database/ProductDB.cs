using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Sanita.Utility.Database.BaseDao;
using Sanita.Utility.Database.Utility;
using Medibox.Model;

namespace Medibox.Database
{
    public class ProductDB : BaseDB
    {
        //Constant
        private const String TAG = "ProductDB";
        //Singleton
        private static ProductDB _instance;
        public static ProductDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductDB();
                }
                return _instance;
            }
        }
        public IList<Product> GetProducts(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_product ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakeProducts(dt));
        }
        public Product GetProduct()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_product ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeProduct(row));
        }
        public Product GetProduct(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_product ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeProduct(row));
        }

        public Product GetProductbyID(int product_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_product ");
            sql.Append(" WHERE product_id = " + product_id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeProduct(row));
        }

        public int UpdateProduct(IDbConnection connection, IDbTransaction trans, Product data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_Product ");
                sql.Append("  SET  ");
                sql.Append("     product_id = " + data.product_id.Escape()).Append(", ");
                sql.Append("     tenant_id = " + data.tenant_id.Escape()).Append(", ");
                sql.Append("      created_on = " + data.created_on.Escape()).Append(", ");
                sql.Append("      modified_on = " + data.modified_on.Escape()).Append(", ");
                sql.Append("      status = " + data.status.Escape()).Append(", ");
                sql.Append("      brand = " + data.brand.Escape()).Append(", ");
                sql.Append("      description = " + data.description.Escape()).Append(", ");
                sql.Append("      image_path = " + data.image_path.Escape()).Append(", ");
                sql.Append("      image_name = " + data.image_name.Escape()).Append(", ");
                sql.Append("      name = " + data.name.Escape()).Append(", ");
                sql.Append("      opt1 = " + data.opt1.Escape()).Append(", ");
                sql.Append("      opt2 = " + data.opt2.Escape()).Append(", ");
                sql.Append("      opt3 = " + data.opt3.Escape()).Append(", ");
                sql.Append("      category = " + data.category.Escape()).Append(", ");
                sql.Append("      category_code = " + data.category_code.Escape()).Append(", ");
                sql.Append("      tags = " + data.tags.Escape()).Append(", ");
                sql.Append("      medicine = " + data.medicine.Escape()).Append(", ");
                sql.Append("      product_type = " + data.product_type.Escape()).Append(", ");
                sql.Append("      product_medicines = " + data.product_medicines.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertProduct(IDbConnection connection, IDbTransaction trans, Product data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_product (");
                sql.Append("            product_id,");
                sql.Append("            tenant_id,");
                sql.Append("            created_on,");
                sql.Append("            modified_on,");
                sql.Append("            status,");
                sql.Append("            brand,");
                sql.Append("            description,");
                sql.Append("            image_path,");
                sql.Append("            image_name,");
                sql.Append("            name,");
                sql.Append("            opt1,");
                sql.Append("            opt2,");
                sql.Append("            opt3,");
                sql.Append("            category,");
                sql.Append("            category_code,");
                sql.Append("            tags,");
                sql.Append("            medicine,");
                sql.Append("            product_type,");
                sql.Append("            product_medicines)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.product_id.Escape()).Append(", ");
                sql.Append("          " + data.tenant_id.Escape()).Append(", ");
                sql.Append("          " + data.created_on.Escape()).Append(", ");
                sql.Append("          " + data.modified_on.Escape()).Append(", ");
                sql.Append("          " + data.status.Escape()).Append(", ");
                sql.Append("          " + data.brand.Escape()).Append(", ");
                sql.Append("          " + data.description.Escape()).Append(", ");
                sql.Append("          " + data.image_path.Escape()).Append(", ");
                sql.Append("          " + data.image_name.Escape()).Append(", ");
                sql.Append("          " + data.name.Escape()).Append(", ");
                sql.Append("          " + data.opt1.Escape()).Append(", ");
                sql.Append("          " + data.opt2.Escape()).Append(", ");
                sql.Append("          " + data.opt3.Escape()).Append(", ");
                sql.Append("          " + data.category.Escape()).Append(", ");
                sql.Append("          " + data.category_code.Escape()).Append(", ");
                sql.Append("          " + data.tags.Escape()).Append(", ");
                sql.Append("          " + data.medicine.Escape()).Append(", ");
                sql.Append("          " + data.product_type.Escape()).Append(", ");
                sql.Append("          " + data.product_medicines.Escape()).Append(") ");
                int newId = baseDAO.DoInsert(connection, trans, sql.ToString());
                data.id = newId;
                if (newId > 0)
                {
                    return newId;
                }
                else
                {
                    return DataTypeModel.RESULT_NG;
                }
            }
        }
        public int DeleteProduct(Product data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_product  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<Product> MakeProducts(DataTable dt)
        {
            IList<Product> list = new List<Product>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakeProduct(row));
                }
            }
            return list;
        }
        private Product MakeProduct(DataRow row)
        {
            Product record = new Product();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}
