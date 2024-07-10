using System;
using System.Collections.Generic;
using System.Linq;

namespace Medibox.Model
{
    [Serializable()]
    public class PriceList
    {
        public int id { get; set; }
        public int pricelist_id { get; set; }
        public int variant_id { get; set; }
        public int tenant_id { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public string code { get; set; }
        public int currency_id { get; set; }
        public string name { get; set; }
        public string is_cost { get; set; }
        public string currency_symbol { get; set; }
        public string currency_iso { get; set; }
        public string status { get; set; }
        public string init { get; set; }

        //------------------------------------------------------------

        //Ref
        
    }
}
