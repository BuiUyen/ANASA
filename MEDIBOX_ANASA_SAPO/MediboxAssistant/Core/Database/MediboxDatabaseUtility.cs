using System;
using System.Collections.Generic;
using Sanita.Utility.Database.BaseDao;
using Sanita.Utility.Database.Utility;

namespace Medibox.Database
{
    public class MediboxDatabaseUtility
    {
        private const String TAG = "MediboxDatabaseUtility";
        private static DatabaseUtility mDatabaseUtility_Main = new DatabaseUtility();
        public static void InitDatabase()
        {
            mDatabaseUtility_Main.GetDatabaseImplementUtility().InitDatabase(GetDatabaseDAO(), InitTable());
        }
        public static IBaseDao GetDatabaseDAO()
        {
            return mDatabaseUtility_Main.GetDatabaseDAO();
        }
        public static DatabaseUtility GetDatabaseUtility()
        {
            return mDatabaseUtility_Main;
        }
        public static string GetDatabaseVersion()
        {
            return "20";
        }
        public static List<ClassTable> InitTable()
        {
            List<ClassTable> listFixTable = new List<ClassTable>();

            #region tb_user
            ClassTable tb_user = new ClassTable();
            tb_user.Table = "tb_user";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "UserID";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "UserCode";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "UserName";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "UserPassword";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "APIKey";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "LocaltionName";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Latitude";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Longitude";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "HassIO_URL";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "HassIO_KEY";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_user.listColumn = listColumn;
            }
            listFixTable.Add(tb_user);
            #endregion

            #region tb_device
            ClassTable tb_device = new ClassTable();
            tb_device.Table = "tb_device";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "DeviceID";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "DeviceName";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "DeviceName_Short";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "DeviceCode";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Hass_Entity_ID";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "DM_Hass_DeviceTypeID";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "RoomID";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "UserID";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "HomeID";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_device.listColumn = listColumn;
            }
            listFixTable.Add(tb_device);
            #endregion

            #region tb_sanphamweb
            ClassTable tb_sanphamweb = new ClassTable();
            tb_sanphamweb.Table = "tb_sanphamweb";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "SanPhamWebID";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Alias";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "TenSanPham";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "NoiDung";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "NhaCungCap";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Loai";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Tag";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "HienThi";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ThuocTinh";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "GiaTriThuocTinh";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ThuocTinh2";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "GiaTriThuocTinh2";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ThuocTinh3";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "GiaTriThuocTinh3";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "SKU";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "QuanLyKho";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "SoLuong";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ChoPhepBan";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Variant";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Gia";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "GiaSoSanh";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "YeuCauVanChuyen";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "VAT";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "MaVach";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "AnhDaiDien";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ChuThich";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "TheTieuDe";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "TheMoTa";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "CanNang";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "DonViCan";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "AnhPhienBan";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "MoTaNgan";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ID";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "IDTuyChon";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "TenPhienBan";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "MaNganhSenDo";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "ThongSo";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "CongDung";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_sanphamweb.listColumn = listColumn;
            }
            listFixTable.Add(tb_sanphamweb);
            #endregion

            #region tb_product
            ClassTable tb_product = new ClassTable();
            tb_product.Table = "tb_product";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "tenant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "created_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "modified_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "status";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "brand";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "description";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "image_path";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "image_name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "opt1";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "opt2";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "opt3";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "category";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "category_code";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "tags";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "medicine";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_type";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_medicines";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_product.listColumn = listColumn;
            }
            listFixTable.Add(tb_product);
            #endregion

            #region tb_variant
            ClassTable tb_variant = new ClassTable();
            tb_variant.Table = "tb_variant";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "tenant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "location_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "created_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "modified_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "category_id";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "brand_id";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "composite";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "init_price";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "init_stock";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_retail_price";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_whole_price";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_import_price";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "image_id";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "description";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "opt1";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "opt2";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "opt3";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_status";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "status";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "sellable";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "sku";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "barcode";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "taxable";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "weight_value";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "weight_unit";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "unit";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "packsize";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "packsize_quantity";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "packsize_root_id";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "packsize_root_sku";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "packsize_root_name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "tax_included";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "input_vat_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "output_vat_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "input_vat_rate";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "output_vat_rate";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_type";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "warranty";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "warranty_term_id";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "expiration_alert_time";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_variant.listColumn = listColumn;
            }
            listFixTable.Add(tb_variant);
            #endregion

            #region tb_option
            ClassTable tb_option = new ClassTable();
            tb_option.Table = "tb_option";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "option_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "position";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "stringvalues";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_option.listColumn = listColumn;
            }
            listFixTable.Add(tb_option);
            #endregion

            #region tb_image
            ClassTable tb_image = new ClassTable();
            tb_image.Table = "tb_image";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "image_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }

                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "product_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }

                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "tenant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "size";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "created_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "modified_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "path";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "full_path";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "file_name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "is_default";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "position";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_image.listColumn = listColumn;
            }
            listFixTable.Add(tb_image);
            #endregion

            #region tb_variantprice
            ClassTable tb_variantprice = new ClassTable();
            tb_variantprice.Table = "tb_variantprice";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variantprice_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "value";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "included_tax_price";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "price_list_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_variantprice.listColumn = listColumn;
            }
            listFixTable.Add(tb_variantprice);
            #endregion

            #region tb_pricelist
            ClassTable tb_pricelist = new ClassTable();
            tb_pricelist.Table = "tb_pricelist";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "pricelist_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "tenant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "created_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "modified_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "code";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "currency_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "name";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "is_cost";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "currency_symbol";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "currency_iso";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "status";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "init";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_pricelist.listColumn = listColumn;
            }
            listFixTable.Add(tb_pricelist);
            #endregion

            #region tb_inventory
            ClassTable tb_inventory = new ClassTable();
            tb_inventory.Table = "tb_inventory";
            {
                IList<ClassColumn> listColumn = new List<ClassColumn>();
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "id";
                    Column.ColumnDefine = " int(10) unsigned NOT NULL auto_increment ";
                    Column.isPRIMARY = true;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "inventory_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "location_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "variant_id";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "mac";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "amount";
                    Column.ColumnDefine = " int(10) DEFAULT '0' ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "on_hand";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "available";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "committed";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "incoming";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "onway";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "min_value";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "max_value";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "bin_location";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "wait_to_pack";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "modified_on";
                    Column.ColumnDefine = " text CHARACTER SET utf8 COLLATE utf8_unicode_ci ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                {
                    ClassColumn Column = new ClassColumn();
                    Column.ColumnName = "Version";
                    Column.ColumnDefine = " timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP ";
                    Column.isPRIMARY = false;
                    listColumn.Add(Column);
                }
                tb_inventory.listColumn = listColumn;
            }
            listFixTable.Add(tb_inventory);
            #endregion

            return listFixTable;
        }
    }
}
