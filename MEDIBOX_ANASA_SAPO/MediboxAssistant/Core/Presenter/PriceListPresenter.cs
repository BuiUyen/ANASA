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

    public class PriceListPresenter : BasePresenter
    {
        private const String TAG = "PriceListPresenter";
        public static IList<PriceList> GetPriceLists()
        {
            return PriceListDB.mInstance.GetPriceLists(null,null);
        }

        public static PriceList GetPriceList()
        {
            return PriceListDB.mInstance.GetPriceList();
        }

        public static PriceList GetPriceList(int id)
        {
            return PriceListDB.mInstance.GetPriceList(id);
        }
        public static void UpdatePriceList(PriceList data)
        {
            PriceListDB.mInstance.UpdatePriceList(null, null, data);
        }

        public static void InsertPriceList(PriceList data)
        {
            PriceListDB.mInstance.InsertPriceList(null, null, data);
        }

        public static int DeletePriceList(PriceList data)
        {
            return PriceListDB.mInstance.DeletePriceList(data);
        }
    }
}

