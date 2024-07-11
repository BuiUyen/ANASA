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
    public class VariantDB : BaseDB
    {
        //Constant
        private const String TAG = "VariantDB";
        //Singleton
        private static VariantDB _instance;
        public static VariantDB mInstance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new VariantDB();
                }
                return _instance;
            }
        }
        public IList<Variant> GetVariants(IDbConnection connection, IDbTransaction trans)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variant ");
            DataTable dt = baseDAO.DoGetDataTable(connection, trans, sql.ToString());
            return (MakeVariants(dt));
        }
        public Variant GetVariant()
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variant ");
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeVariant(row));
        }
        public Variant GetVariant(int id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variant ");
            sql.Append(" WHERE id = " + id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeVariant(row));
        }

        public Variant GetVariantbyID(int variant_id)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" SELECT * ");
            sql.Append(" FROM tb_variant ");
            sql.Append(" WHERE variant_id = " + variant_id.Escape());
            DataRow row = baseDAO.DoGetDataRow(sql.ToString());
            return (MakeVariant(row));
        }

        public int UpdateVariant(IDbConnection connection, IDbTransaction trans, Variant data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }

                StringBuilder sql = new StringBuilder();
                sql.Append(" UPDATE tb_Variant ");
                sql.Append("  SET  ");
                sql.Append("     variant_id = " + data.variant_id.Escape()).Append(", ");
                sql.Append("     tenant_id = " + data.tenant_id.Escape()).Append(", ");
                sql.Append("     location_id = " + data.location_id.Escape()).Append(", ");
                sql.Append("      created_on = " + data.created_on.Escape()).Append(", ");
                sql.Append("      modified_on = " + data.modified_on.Escape()).Append(", ");
                sql.Append("      category_id = " + data.category_id.Escape()).Append(", ");
                sql.Append("      brand_id = " + data.brand_id.Escape()).Append(", ");
                sql.Append("     product_id = " + data.product_id.Escape()).Append(", ");
                sql.Append("      composite = " + data.composite.Escape()).Append(", ");
                sql.Append("      init_price = " + data.init_price.Escape()).Append(", ");
                sql.Append("      init_stock = " + data.init_stock.Escape()).Append(", ");
                sql.Append("      variant_retail_price = " + data.variant_retail_price.Escape()).Append(", ");
                sql.Append("      variant_whole_price = " + data.variant_whole_price.Escape()).Append(", ");
                sql.Append("      variant_import_price = " + data.variant_import_price.Escape()).Append(", ");
                sql.Append("      image_id = " + data.image_id.Escape()).Append(", ");
                sql.Append("      description = " + data.description.Escape()).Append(", ");
                sql.Append("      name = " + data.name.Escape()).Append(", ");
                sql.Append("      opt1 = " + data.opt1.Escape()).Append(", ");
                sql.Append("      opt2 = " + data.opt2.Escape()).Append(", ");
                sql.Append("      opt3 = " + data.opt3.Escape()).Append(", ");
                sql.Append("      product_name = " + data.product_name.Escape()).Append(", ");
                sql.Append("      product_status = " + data.product_status.Escape()).Append(", ");
                sql.Append("      status = " + data.status.Escape()).Append(", ");
                sql.Append("      sellable = " + data.sellable.Escape()).Append(", ");
                sql.Append("      sku = " + data.sku.Escape()).Append(", ");
                sql.Append("      barcode = " + data.barcode.Escape()).Append(", ");
                sql.Append("      taxable = " + data.taxable.Escape()).Append(", ");
                sql.Append("      weight_value = " + data.weight_value.Escape()).Append(", ");
                sql.Append("      weight_unit = " + data.weight_unit.Escape()).Append(", ");
                sql.Append("      unit = " + data.unit.Escape()).Append(", ");
                sql.Append("      packsize = " + data.packsize.Escape()).Append(", ");
                sql.Append("      packsize_quantity = " + data.packsize_quantity.Escape()).Append(", ");
                sql.Append("      packsize_root_id = " + data.packsize_root_id.Escape()).Append(", ");
                sql.Append("      packsize_root_sku = " + data.packsize_root_sku.Escape()).Append(", ");
                sql.Append("      packsize_root_name = " + data.packsize_root_name.Escape()).Append(", ");
                sql.Append("      tax_included = " + data.tax_included.Escape()).Append(", ");
                sql.Append("     input_vat_id = " + data.input_vat_id.Escape()).Append(", ");
                sql.Append("     output_vat_id = " + data.output_vat_id.Escape()).Append(", ");
                sql.Append("      input_vat_rate = " + data.input_vat_rate.Escape()).Append(", ");
                sql.Append("      output_vat_rate = " + data.output_vat_rate.Escape()).Append(", ");
                sql.Append("      product_type = " + data.product_type.Escape()).Append(", ");
                sql.Append("      warranty = " + data.warranty.Escape()).Append(", ");
                sql.Append("      warranty_term_id = " + data.warranty_term_id.Escape()).Append(", ");
                sql.Append("      expiration_alert_time = " + data.expiration_alert_time.Escape());
                sql.Append("  WHERE id = " + data.id);
                return baseDAO.DoUpdate(connection, trans, sql.ToString());
            }
        }
        public int InsertVariant(IDbConnection connection, IDbTransaction trans, Variant data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" INSERT INTO tb_variant (");
                sql.Append("            variant_id,");
                sql.Append("            tenant_id,");
                sql.Append("            location_id,");
                sql.Append("            created_on,");
                sql.Append("            modified_on,");
                sql.Append("            category_id,");
                sql.Append("            brand_id,");
                sql.Append("            product_id,");
                sql.Append("            composite,");
                sql.Append("            init_price,");
                sql.Append("            init_stock,");
                sql.Append("            variant_retail_price,");
                sql.Append("            variant_whole_price,");
                sql.Append("            variant_import_price,");
                sql.Append("            image_id,");
                sql.Append("            description,");
                sql.Append("            name,");
                sql.Append("            opt1,");
                sql.Append("            opt2,");
                sql.Append("            opt3,");
                sql.Append("            product_name,");
                sql.Append("            product_status,");
                sql.Append("            status,");
                sql.Append("            sellable,");
                sql.Append("            sku,");
                sql.Append("            barcode,");
                sql.Append("            taxable,");
                sql.Append("            weight_value,");
                sql.Append("            weight_unit,");
                sql.Append("            unit,");
                sql.Append("            packsize,");
                sql.Append("            packsize_quantity,");
                sql.Append("            packsize_root_id,");
                sql.Append("            packsize_root_sku,");
                sql.Append("            packsize_root_name,");
                sql.Append("            tax_included,");
                sql.Append("            input_vat_id,");
                sql.Append("            output_vat_id,");
                sql.Append("            input_vat_rate,");
                sql.Append("            output_vat_rate,");
                sql.Append("            product_type,");
                sql.Append("            warranty,");
                sql.Append("            warranty_term_id,");
                sql.Append("            expiration_alert_time)");
                sql.Append("  VALUES( ");
                sql.Append("          " + data.variant_id.Escape()).Append(", ");
                sql.Append("          " + data.tenant_id.Escape()).Append(", ");
                sql.Append("          " + data.location_id.Escape()).Append(", ");
                sql.Append("          " + data.created_on.Escape()).Append(", ");
                sql.Append("          " + data.modified_on.Escape()).Append(", ");
                sql.Append("          " + data.category_id.Escape()).Append(", ");
                sql.Append("          " + data.brand_id.Escape()).Append(", ");
                sql.Append("          " + data.product_id.Escape()).Append(", ");
                sql.Append("          " + data.composite.Escape()).Append(", ");
                sql.Append("          " + data.init_price.Escape()).Append(", ");
                sql.Append("          " + data.init_stock.Escape()).Append(", ");
                sql.Append("          " + data.variant_retail_price.Escape()).Append(", ");
                sql.Append("          " + data.variant_whole_price.Escape()).Append(", ");
                sql.Append("          " + data.variant_import_price.Escape()).Append(", ");
                sql.Append("          " + data.image_id.Escape()).Append(", ");
                sql.Append("          " + data.description.Escape()).Append(", ");
                sql.Append("          " + data.name.Escape()).Append(", ");
                sql.Append("          " + data.opt1.Escape()).Append(", ");
                sql.Append("          " + data.opt2.Escape()).Append(", ");
                sql.Append("          " + data.opt3.Escape()).Append(", ");
                sql.Append("          " + data.product_name.Escape()).Append(", ");
                sql.Append("          " + data.product_status.Escape()).Append(", ");
                sql.Append("          " + data.status.Escape()).Append(", ");
                sql.Append("          " + data.sellable.Escape()).Append(", ");
                sql.Append("          " + data.sku.Escape()).Append(", ");
                sql.Append("          " + data.barcode.Escape()).Append(", ");
                sql.Append("          " + data.taxable.Escape()).Append(", ");
                sql.Append("          " + data.weight_value.Escape()).Append(", ");
                sql.Append("          " + data.weight_unit.Escape()).Append(", ");
                sql.Append("          " + data.unit.Escape()).Append(", ");
                sql.Append("          " + data.packsize.Escape()).Append(", ");
                sql.Append("          " + data.packsize_quantity.Escape()).Append(", ");
                sql.Append("          " + data.packsize_root_id.Escape()).Append(", ");
                sql.Append("          " + data.packsize_root_sku.Escape()).Append(", ");
                sql.Append("          " + data.packsize_root_name.Escape()).Append(", ");
                sql.Append("          " + data.tax_included.Escape()).Append(", ");
                sql.Append("          " + data.input_vat_id.Escape()).Append(", ");
                sql.Append("          " + data.output_vat_id.Escape()).Append(", ");
                sql.Append("          " + data.input_vat_rate.Escape()).Append(", ");
                sql.Append("          " + data.output_vat_rate.Escape()).Append(", ");
                sql.Append("          " + data.product_type.Escape()).Append(", ");
                sql.Append("          " + data.warranty.Escape()).Append(", ");
                sql.Append("          " + data.warranty_term_id.Escape()).Append(", ");
                sql.Append("          " + data.expiration_alert_time.Escape()).Append(") ");
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
        public int DeleteVariant(Variant data)
        {
            lock (lockObject)
            {
                if (data == null)
                {
                    return DataTypeModel.RESULT_NG;
                }
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM tb_variant  ");
                sql.Append("  WHERE id = " + DatabaseUtility.Escape(data.id));
                return baseDAO.DoUpdate(sql.ToString());
            }
        }
        #region Utility
        private IList<Variant> MakeVariants(DataTable dt)
        {
            IList<Variant> list = new List<Variant>();
            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    list.Add(MakeVariant(row));
                }
            }
            return list;
        }
        private Variant MakeVariant(DataRow row)
        {
            Variant record = new Variant();
            if (row != null)
            {
                record.SetProperty(row);
            }
            return record;
        }
        #endregion
    }
}
