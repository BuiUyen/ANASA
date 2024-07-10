using System;
using System.Collections.Generic;
using System.Linq;

namespace Medibox.Model
{
    [Serializable()]
    public class Option
    {
        public int id { get; set; }
        public int option_id { get; set; }
        public int tenant_id { get; set; }
        public string name { get; set; }
        public int position { get; set; }
        public string stringvalues { get; set; }

        //------------------------------------------------------------

        //Ref
        //
        public List<string> values { get; set; }
    }
}
