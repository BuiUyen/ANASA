using System;
using System.Collections.Generic;
using System.Linq;

namespace Medibox.Model
{
    [Serializable()]
    public class Image
    {
        public int id { get; set; }
        public int image_id { get; set; }
        public int product_id { get; set; }
        public int tenant_id { get; set; }
        public string size { get; set; }
        public string created_on { get; set; }
        public string modified_on { get; set; }
        public string path { get; set; }
        public string full_path { get; set; }
        public string file_name { get; set; }
        public string is_default { get; set; }
        public int position { get; set; }

        //------------------------------------------------------------

        //Ref        
    }
}
