using System;
using System.Collections.Generic;
using System.Linq;

namespace Medibox.Model
{
    [Serializable()]
    public class Product
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public int tenant_id { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public string status { get; set; }
        public string brand { get; set; }
        public string description { get; set; }
        public string image_path { get; set; }
        public string image_name { get; set; }
        public string name { get; set; }
        public string opt1 { get; set; }
        public string opt2 { get; set; }
        public string opt3 { get; set; }
        public string category { get; set; }
        public string category_code { get; set; }
        public string tags { get; set; }
        public string medicine { get; set; }
        public string product_type { get; set; }        
        public string product_medicines { get; set; }


        //------------------------------------------------------------

        //Ref
        public IList<Variant> variants { get; set; }
        public IList<Option> options { get; set; }
        public IList<Image> images { get; set; }
    }
}
