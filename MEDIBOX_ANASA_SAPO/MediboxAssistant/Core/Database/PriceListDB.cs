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
    public class PriceListDB : BaseDB
    {
        //Constant
        private const String TAG = "PriceListDB";
        //Singleton
        private static PriceListDB _instance;
        public static PriceListDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new PriceListDB();
                }
                return _instance;
            }
        }
        public IList<PriceList> GetPriceLists(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_pricelist ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakePriceLists(dt));
        }
        public PriceList GetPriceList()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_pricelist ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakePriceList(row));
        }
        public PriceList GetPriceList(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_pricelist ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakePriceList(row));
        }
        public PriceList GetPriceListbyID(int pricelist_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_pricelist ");
            sql.Append(" WHERE pricelist_id = " + pricelist_id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakePriceList(row));
        }

        public int UpdatePriceList(IDbConnection connection, IDbTransaction trans, PriceList data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_PriceList ");
                sql.Append("  SET  ");
                sql.Append("     pricelist_id = " + data.pricelist_id.Escape()).Append(", ");
                sql.Append("     variant_id = " + data.variant_id.Escape()).Append(", ");
                sql.Append("     tenant_id = " + data.tenant_id.Escape()).Append(", ");
                sql.Append("      created_on = " + data.created_on.Escape()).Append(", ");
                sql.Append("      modified_on = " + data.modified_on.Escape()).Append(", ");
                sql.Append("      code = " + data.code.Escape()).Append(", ");
                sql.Append("     currency_id = " + data.currency_id.Escape()).Append(", ");
                sql.Append("      name = " + data.name.Escape()).Append(", ");
                sql.Append("      is_cost = " + data.is_cost.Escape()).Append(", ");
                sql.Append("      currency_symbol = " + data.currency_symbol.Escape()).Append(", ");
                sql.Append("      currency_iso = " + data.currency_iso.Escape()).Append(", ");
                sql.Append("      status = " + data.status.Escape()).Append(", ");
                sql.Append("      init = " + data.init.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertPriceList(IDbConnection connection, IDbTransaction trans, PriceList data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_pricelist (");
                sql.Append("            pricelist_id,");
                sql.Append("            variant_id,");
                sql.Append("            tenant_id,");
                sql.Append("            created_on,");
                sql.Append("            modified_on,");
                sql.Append("            code,");
                sql.Append("            currency_id,");
                sql.Append("            name,");
                sql.Append("            is_cost,");
                sql.Append("            currency_symbol,");
                sql.Append("            currency_iso,");
                sql.Append("            status,");
                sql.Append("            init)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.pricelist_id.Escape()).Append(", ");
                sql.Append("          " + data.variant_id.Escape()).Append(", ");
                sql.Append("          " + data.tenant_id.Escape()).Append(", ");
                sql.Append("          " + data.created_on.Escape()).Append(", ");
                sql.Append("          " + data.modified_on.Escape()).Append(", ");
                sql.Append("          " + data.code.Escape()).Append(", ");
                sql.Append("          " + data.currency_id.Escape()).Append(", ");
                sql.Append("          " + data.name.Escape()).Append(", ");
                sql.Append("          " + data.is_cost.Escape()).Append(", ");
                sql.Append("          " + data.currency_symbol.Escape()).Append(", ");
                sql.Append("          " + data.currency_iso.Escape()).Append(", ");
                sql.Append("          " + data.status.Escape()).Append(", ");
                sql.Append("          " + data.init.Escape()).Append(") ");
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
        public int DeletePriceList(PriceList data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_pricelist  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<PriceList> MakePriceLists(DataTable dt)
        {
            IList<PriceList> list = new List<PriceList>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakePriceList(row));
                }
            }
            return list;
        }
        private PriceList MakePriceList(DataRow row)
        {
            PriceList record = new PriceList();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}