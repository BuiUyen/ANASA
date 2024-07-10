using System;
using System.Collections.Generic;
using System.Linq;

namespace Medibox.Model
{
    [Serializable()]
    public class Inventory
    {
        public int id { get; set; }
        public int inventory_id { get; set; }
        public int location_id { get; set; }
        public int variant_id { get; set; }
        public string mac { get; set; }
        public int amount { get; set; }
        public string on_hand { get; set; }
        public string available { get; set; }
        public string committed { get; set; }
        public string incoming { get; set; }
        public string onway { get; set; }
        public string min_value { get; set; }
        public string max_value { get; set; }
        public string bin_location { get; set; }
        public string wait_to_pack { get; set; }
        public string modified_on { get; set; }


        //------------------------------------------------------------

        //Ref

    }
}
