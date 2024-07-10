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
    public class ImageDB : BaseDB
    {
        //Constant
        private const String TAG = "ImageDB";
        //Singleton
        private static ImageDB _instance;
        public static ImageDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ImageDB();
                }
                return _instance;
            }
        }
        public IList<Image> GetImages(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_image ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakeImages(dt));
        }
        public Image GetImage()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_image ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeImage(row));
        }
        public Image GetImage(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_image ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeImage(row));
        }
        public int UpdateImage(IDbConnection connection, IDbTransaction trans, Image data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_Image ");
                sql.Append("  SET  ");
                sql.Append("     image_id = " + data.image_id.Escape()).Append(", ");
                sql.Append("     tenant_id = " + data.tenant_id.Escape()).Append(", ");
                sql.Append("      size = " + data.size.Escape()).Append(", ");
                sql.Append("      created_on = " + data.created_on.Escape()).Append(", ");
                sql.Append("      modified_on = " + data.modified_on.Escape()).Append(", ");
                sql.Append("      path = " + data.path.Escape()).Append(", ");
                sql.Append("      full_path = " + data.full_path.Escape()).Append(", ");
                sql.Append("      file_name = " + data.file_name.Escape()).Append(", ");
                sql.Append("      is_default = " + data.is_default.Escape()).Append(", ");
                sql.Append("     position = " + data.position.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertImage(IDbConnection connection, IDbTransaction trans, Image data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_image (");
                sql.Append("            image_id,");
                sql.Append("            tenant_id,");
                sql.Append("            size,");
                sql.Append("            created_on,");
                sql.Append("            modified_on,");
                sql.Append("            path,");
                sql.Append("            full_path,");
                sql.Append("            file_name,");
                sql.Append("            is_default,");
                sql.Append("            position)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.image_id.Escape()).Append(", ");
                sql.Append("          " + data.tenant_id.Escape()).Append(", ");
                sql.Append("          " + data.size.Escape()).Append(", ");
                sql.Append("          " + data.created_on.Escape()).Append(", ");
                sql.Append("          " + data.modified_on.Escape()).Append(", ");
                sql.Append("          " + data.path.Escape()).Append(", ");
                sql.Append("          " + data.full_path.Escape()).Append(", ");
                sql.Append("          " + data.file_name.Escape()).Append(", ");
                sql.Append("          " + data.is_default.Escape()).Append(", ");
                sql.Append("          " + data.position.Escape()).Append(") ");
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
        public int DeleteImage(Image data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_image  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<Image> MakeImages(DataTable dt)
        {
            IList<Image> list = new List<Image>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakeImage(row));
                }
            }
            return list;
        }
        private Image MakeImage(DataRow row)
        {
            Image record = new Image();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}