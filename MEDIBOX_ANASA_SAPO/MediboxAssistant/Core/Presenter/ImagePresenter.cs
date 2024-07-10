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
    public class ImagePresenter : BasePresenter
    {
        private const String TAG = "ImagePresenter";
        public static IList<Image> GetImages()
        {
            return ImageDB.mInstance.GetImages(null,null);
        }

        public static Image GetImage()
        {
            return ImageDB.mInstance.GetImage();
        }

        public static Image GetImage(int id)
        {
            return ImageDB.mInstance.GetImage(id);
        }
        public static void UpdateImage(Image data)
        {
            ImageDB.mInstance.UpdateImage(null, null, data);
        }

        public static void InsertImage(Image data)
        {
            ImageDB.mInstance.InsertImage(null, null, data);
        }

        public static int DeleteImage(Image data)
        {
            return ImageDB.mInstance.DeleteImage(data);
        }
    }
}

