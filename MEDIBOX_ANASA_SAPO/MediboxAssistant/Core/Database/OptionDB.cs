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
    public class OptionDB : BaseDB
    {
        //Constant
        private const String TAG = "OptionDB";
        //Singleton
        private static OptionDB _instance;
        public static OptionDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OptionDB();
                }
                return _instance;
            }
        }
        public IList<Option> GetOptions(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_option ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakeOptions(dt));
        }
        public Option GetOption()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_option ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeOption(row));
        }
        public Option GetOption(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_option ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeOption(row));
        }
        public int UpdateOption(IDbConnection connection, IDbTransaction trans, Option data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_Option ");
                sql.Append("  SET  ");
                sql.Append("     option_id = " + data.option_id.Escape()).Append(", ");
                sql.Append("     tenant_id = " + data.tenant_id.Escape()).Append(", ");
                sql.Append("      name = " + data.name.Escape()).Append(", ");
                sql.Append("     position = " + data.position.Escape()).Append(", ");
                sql.Append("      stringvalues = " + data.stringvalues.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertOption(IDbConnection connection, IDbTransaction trans, Option data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_option (");
                sql.Append("            option_id,");
                sql.Append("            tenant_id,");
                sql.Append("            name,");
                sql.Append("            position,");
                sql.Append("            stringvalues)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.option_id.Escape()).Append(", ");
                sql.Append("          " + data.tenant_id.Escape()).Append(", ");
                sql.Append("          " + data.name.Escape()).Append(", ");
                sql.Append("          " + data.position.Escape()).Append(", ");
                sql.Append("          " + data.stringvalues.Escape()).Append(") ");
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
        public int DeleteOption(Option data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_option  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<Option> MakeOptions(DataTable dt)
        {
            IList<Option> list = new List<Option>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakeOption(row));
                }
            }
            return list;
        }
        private Option MakeOption(DataRow row)
        {
            Option record = new Option();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}

