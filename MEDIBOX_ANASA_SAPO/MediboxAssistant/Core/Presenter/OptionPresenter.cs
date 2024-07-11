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
    public class OptionPresenter : BasePresenter
    {
        private const String TAG = "OptionPresenter";
        public static IList<Option> GetOptions()
        {
            return OptionDB.mInstance.GetOptions(null,null);
        }

        public static Option GetOption()
        {
            return OptionDB.mInstance.GetOption();
        }

        public static Option GetOption(int id)
        {
            return OptionDB.mInstance.GetOption(id);
        }

        public static Option GetOptionbyID(int option_id)
        {
            return OptionDB.mInstance.GetOptionbyID(option_id);
        }

        public static void UpdateOption(Option data)
        {
            OptionDB.mInstance.UpdateOption(null, null, data);
        }

        public static void InsertOption(Option data)
        {
            OptionDB.mInstance.InsertOption(null, null, data);
        }

        public static int DeleteOption(Option data)
        {
            return OptionDB.mInstance.DeleteOption(data);
        }
    }

}

