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

    public class VariantPricePresenter : BasePresenter
    {
        private const String TAG = "VariantPricePresenter";
        public static IList<VariantPrice> GetVariantPrices()
        {
            return VariantPriceDB.mInstance.GetVariantPrices(null,null);
        }

        public static VariantPrice GetVariantPrice()
        {
            return VariantPriceDB.mInstance.GetVariantPrice();
        }

        public static VariantPrice GetVariantPrice(int id)
        {
            return VariantPriceDB.mInstance.GetVariantPrice(id);
        }

        public static VariantPrice GetVariantPricebyID(int variantprice_id)
        {
            return VariantPriceDB.mInstance.GetVariantPricebyID(variantprice_id);
        }

        public static void UpdateVariantPrice(VariantPrice data)
        {
            VariantPriceDB.mInstance.UpdateVariantPrice(null, null, data);
        }

        public static void InsertVariantPrice(VariantPrice data)
        {
            VariantPriceDB.mInstance.InsertVariantPrice(null, null, data);
        }

        public static int DeleteVariantPrice(VariantPrice data)
        {
            return VariantPriceDB.mInstance.DeleteVariantPrice(data);
        }
    }
}

