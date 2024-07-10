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
    public class VariantPriceDB : BaseDB
    {
        //Constant
        private const String TAG = "VariantPriceDB";
        //Singleton
        private static VariantPriceDB _instance;
        public static VariantPriceDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VariantPriceDB();
                }
                return _instance;
            }
        }
        public IList<VariantPrice> GetVariantPrices(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variantprice ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakeVariantPrices(dt));
        }
        public VariantPrice GetVariantPrice()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variantprice ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeVariantPrice(row));
        }
        public VariantPrice GetVariantPrice(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variantprice ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeVariantPrice(row));
        }
        public int UpdateVariantPrice(IDbConnection connection, IDbTransaction trans, VariantPrice data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_VariantPrice ");
                sql.Append("  SET  ");
                sql.Append("     variantprice_id = " + data.variantprice_id.Escape()).Append(", ");
                sql.Append("     variant_id = " + data.variant_id.Escape()).Append(", ");
                sql.Append("      value = " + data.value.Escape()).Append(", ");
                sql.Append("      included_tax_price = " + data.included_tax_price.Escape()).Append(", ");
                sql.Append("      name = " + data.name.Escape()).Append(", ");
                sql.Append("     price_list_id = " + data.price_list_id.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertVariantPrice(IDbConnection connection, IDbTransaction trans, VariantPrice data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_variantprice (");
                sql.Append("            variantprice_id,");
                sql.Append("            variant_id,");
                sql.Append("            value,");
                sql.Append("            included_tax_price,");
                sql.Append("            name,");
                sql.Append("            price_list_id)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.variantprice_id.Escape()).Append(", ");
                sql.Append("          " + data.variant_id.Escape()).Append(", ");
                sql.Append("          " + data.value.Escape()).Append(", ");
                sql.Append("          " + data.included_tax_price.Escape()).Append(", ");
                sql.Append("          " + data.name.Escape()).Append(", ");
                sql.Append("          " + data.price_list_id.Escape()).Append(") ");
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
        public int DeleteVariantPrice(VariantPrice data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_variantprice  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<VariantPrice> MakeVariantPrices(DataTable dt)
        {
            IList<VariantPrice> list = new List<VariantPrice>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakeVariantPrice(row));
                }
            }
            return list;
        }
        private VariantPrice MakeVariantPrice(DataRow row)
        {
            VariantPrice record = new VariantPrice();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}