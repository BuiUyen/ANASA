using System;
using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Medibox.Model
{
    [Serializable()]
    public class VariantPrice
    {
        public int id { get; set; }
        public int variantprice_id { get; set; }
        public int variant_id { get; set; }
        public string value { get; set; }
        public string included_tax_price { get; set; }
        public string name { get; set; }
        public int price_list_id { get; set; }

        //------------------------------------------------------------

        //Ref
        public PriceList price_list { get; set; }
    }
}
