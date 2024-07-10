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
    public class InventoryDB : BaseDB
    {
        //Constant
        private const String TAG = "InventoryDB";
        //Singleton
        private static InventoryDB _instance;
        public static InventoryDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new InventoryDB();
                }
                return _instance;
            }
        }
        public IList<Inventory> GetInventorys(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_inventory ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakeInventorys(dt));
        }
        public Inventory GetInventory()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_inventory ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeInventory(row));
        }
        public Inventory GetInventory(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_inventory ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeInventory(row));
        }
        public int UpdateInventory(IDbConnection connection, IDbTransaction trans, Inventory data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_Inventory ");
                sql.Append("  SET  ");
                sql.Append("     inventory_id = " + data.inventory_id.Escape()).Append(", ");
                sql.Append("     location_id = " + data.location_id.Escape()).Append(", ");
                sql.Append("     variant_id = " + data.variant_id.Escape()).Append(", ");
                sql.Append("      mac = " + data.mac.Escape()).Append(", ");
                sql.Append("     amount = " + data.amount.Escape()).Append(", ");
                sql.Append("      on_hand = " + data.on_hand.Escape()).Append(", ");
                sql.Append("      available = " + data.available.Escape()).Append(", ");
                sql.Append("      committed = " + data.committed.Escape()).Append(", ");
                sql.Append("      incoming = " + data.incoming.Escape()).Append(", ");
                sql.Append("      onway = " + data.onway.Escape()).Append(", ");
                sql.Append("      min_value = " + data.min_value.Escape()).Append(", ");
                sql.Append("      max_value = " + data.max_value.Escape()).Append(", ");
                sql.Append("      bin_location = " + data.bin_location.Escape()).Append(", ");
                sql.Append("      wait_to_pack = " + data.wait_to_pack.Escape()).Append(", ");
                sql.Append("      modified_on = " + data.modified_on.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertInventory(IDbConnection connection, IDbTransaction trans, Inventory data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_inventory (");
                sql.Append("            inventory_id,");
                sql.Append("            location_id,");
                sql.Append("            variant_id,");
                sql.Append("            mac,");
                sql.Append("            amount,");
                sql.Append("            on_hand,");
                sql.Append("            available,");
                sql.Append("            committed,");
                sql.Append("            incoming,");
                sql.Append("            onway,");
                sql.Append("            min_value,");
                sql.Append("            max_value,");
                sql.Append("            bin_location,");
                sql.Append("            wait_to_pack,");
                sql.Append("            modified_on)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.inventory_id.Escape()).Append(", ");
                sql.Append("          " + data.location_id.Escape()).Append(", ");
                sql.Append("          " + data.variant_id.Escape()).Append(", ");
                sql.Append("          " + data.mac.Escape()).Append(", ");
                sql.Append("          " + data.amount.Escape()).Append(", ");
                sql.Append("          " + data.on_hand.Escape()).Append(", ");
                sql.Append("          " + data.available.Escape()).Append(", ");
                sql.Append("          " + data.committed.Escape()).Append(", ");
                sql.Append("          " + data.incoming.Escape()).Append(", ");
                sql.Append("          " + data.onway.Escape()).Append(", ");
                sql.Append("          " + data.min_value.Escape()).Append(", ");
                sql.Append("          " + data.max_value.Escape()).Append(", ");
                sql.Append("          " + data.bin_location.Escape()).Append(", ");
                sql.Append("          " + data.wait_to_pack.Escape()).Append(", ");
                sql.Append("          " + data.modified_on.Escape()).Append(") ");
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
        public int DeleteInventory(Inventory data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_inventory  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<Inventory> MakeInventorys(DataTable dt)
        {
            IList<Inventory> list = new List<Inventory>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakeInventory(row));
                }
            }
            return list;
        }
        private Inventory MakeInventory(DataRow row)
        {
            Inventory record = new Inventory();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}