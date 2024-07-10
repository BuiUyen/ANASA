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
    public class VariantPresenter : BasePresenter
    {
        private const String TAG = "VariantPresenter";
        public static IList<Variant> GetVariants()
        {
            return VariantDB.mInstance.GetVariants(null,null);
        }

        public static Variant GetVariant()
        {
            return VariantDB.mInstance.GetVariant();
        }

        public static Variant GetVariant(int id)
        {
            return VariantDB.mInstance.GetVariant(id);
        }
        public static void UpdateVariant(Variant data)
        {
            VariantDB.mInstance.UpdateVariant(null, null, data);
        }

        public static void InsertVariant(Variant data)
        {
            VariantDB.mInstance.InsertVariant(null, null, data);
        }

        public static int DeleteVariant(Variant data)
        {
            return VariantDB.mInstance.DeleteVariant(data);
        }
    }
}

