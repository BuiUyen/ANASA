using System;
using System.Collections.Generic;
using System.Linq;

namespace Medibox.Model
{
    [Serializable()]
    public class Variant
    {
        public int id { get; set; }
        public int variant_id { get; set; }
        public int tenant_id { get; set; }
        public int location_id { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public string category_id { get; set; }
        public string brand_id { get; set; }
        public int product_id { get; set; }
        public string composite { get; set; }
        public string init_price { get; set; }
        public string init_stock { get; set; }
        public string variant_retail_price { get; set; }
        public string variant_whole_price { get; set; }
        public string variant_import_price { get; set; }
        public string image_id { get; set; } //id ảnh đại diện
        public string description { get; set; }
        public string name { get; set; }
        public string opt1 { get; set; }
        public string opt2 { get; set; }
        public string opt3 { get; set; }
        public string product_name { get; set; }
        public string product_status { get; set; }
        public string status { get; set; }
        public string sellable { get; set; }
        public string sku { get; set; }
        public string barcode { get; set; }
        public string taxable { get; set; }
        public string weight_value { get; set; }
        public string weight_unit { get; set; }
        public string unit { get; set; }
        public string packsize { get; set; }
        public string packsize_quantity { get; set; }
        public string packsize_root_id { get; set; }
        public string packsize_root_sku { get; set; }
        public string packsize_root_name { get; set; }
        public string tax_included { get; set; }
        public int input_vat_id { get; set; }
        public int output_vat_id { get; set; }
        public string input_vat_rate { get; set; }
        public string output_vat_rate { get; set; }
        public string product_type { get; set; }        
        public string warranty { get; set; }
        public string warranty_term_id { get; set; }
        public string expiration_alert_time { get; set; }


        //------------------------------------------------------------

        //Ref

        public List<VariantPrice> variant_prices { get; set; }
        public List<Inventory> inventories { get; set; }
        public List<Image> images { get; set; }

    }
}
