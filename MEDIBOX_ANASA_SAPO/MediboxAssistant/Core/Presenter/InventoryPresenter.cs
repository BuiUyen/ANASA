using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Medibox.Database;
using Medibox.Model;
using Sanita.Utility.Database.BaseDao;
using Sanita.Utility.Database.Utility;
using Sanita.Utility.ExtendedThread;

namespace Medibox.Presenter
{

    public class InventoryPresenter : BasePresenter
    {
        private const String TAG = "InventoryPresenter";
        public static IList<Inventory> GetInventorys()
        {
            return InventoryDB.mInstance.GetInventorys(null,null);
        }

        public static Inventory GetInventory()
        {
            return InventoryDB.mInstance.GetInventory();
        }

        public static Inventory GetInventory(int id)
        {
            return InventoryDB.mInstance.GetInventory(id);
        }

        public static IList<Inventory> GetInventorysbyVarID(int variant_id)
        {
            return InventoryDB.mInstance.GetInventorysbyVarID(variant_id);
        }

        public static void UpdateInventory(Inventory data)
        {
            InventoryDB.mInstance.UpdateInventory(null, null, data);
        }

        public static void InsertInventory(Inventory data)
        {
            InventoryDB.mInstance.InsertInventory(null, null, data);
        }

        public static int DeleteInventory(Inventory data)
        {
            return InventoryDB.mInstance.DeleteInventory(data);
        }
    }
}

