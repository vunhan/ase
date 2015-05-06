using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.GUI;

namespace TestAppQuanLyNhaHang.DAL
{
    class ProductDAL
    {
        ConnectionDAL connect = new ConnectionDAL();

        /// <summary>
        /// Load all Store information
        /// </summary>
        /// <returns></returns>
        public DataTable ProductLoadAll()
        {
            return connect.LoadData("sp_Product_GetByAll");
        }
        public DataTable ProductLoadByID(ProductEntity productEntity)
        {
            int param = 1;

            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "@ProductID";
            value[0] = productEntity.ProductID;

            return connect.LoadData("sp_Product_LoadByID", name, value, param);
        }

        /// <summary>
        /// Load all Product Information from Database by ProductType ID
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public DataTable ProductLoadByProductTypeID(ProductEntity productEntity)
        {
            int param = 1;

            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "@ProductTypeID";
            value[0] = productEntity.ProductTypeID;

            return connect.LoadData("sp_Product_LoadByProductTypeID", name, value, param);
        }

        /// <summary>
        /// Search produce by name
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public DataTable ProductSearchProductByName(ProductEntity productEntity)
        {
            int param = 1;
            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "@ProductName"; value[0] = productEntity.ProductName;

            return connect.LoadData("sp_Product_Search_Product_By_Name", name, value, param);
        }

        /// <summary>
        /// Insert Information Product
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public int ProductInsert(ProductEntity productEntity)
        {
            int param = 13;

            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "@ProductID"; value[0] = productEntity.ProductID;
            name[1] = "@ProductTypeID"; value[1] = productEntity.ProductTypeID;
            name[2] = "@CategoryID"; value[2] = productEntity.CategoryID;
            name[3] = "@UnitID"; value[3] = productEntity.UnitID;
            name[4] = "@SupplierID"; value[4] = productEntity.SupplierID;
            name[5] = "@ProductName"; value[5] = productEntity.ProductName;
            name[6] = "@ProductBuyPrice"; value[6] = productEntity.ProductBuyPrice;
            name[7] = "@ProductSalePrice"; value[7] = productEntity.ProductSalePrice;
            name[8] = "@ProductManufactureDate"; value[8] = productEntity.ProductManufactureDate;
            name[9] = "@ProductExpiryDate"; value[9] = productEntity.ProductExpiryDate;
            name[10] = "@ProductImportDate"; value[10] = productEntity.ProductImportDate;
            name[11] = "@VAT"; value[11] = productEntity.VAT;
            name[12] = "@ProductImage"; value[12] = productEntity.ProductImage;

            return connect.Update("sp_Product_Insert", name, value, param);
        }

        /// <summary>
        /// Update Information Product
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public int ProductUpdate(ProductEntity productEntity)
        {
            int param = 11;

            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "@UnitID"; value[0] = productEntity.UnitID;
            name[1] = "@ProductTypeID"; value[1] = productEntity.ProductTypeID;
            name[2] = "@ProductName"; value[2] = productEntity.ProductName;
            name[3] = "@ProductBuyPrice"; value[3] = productEntity.ProductBuyPrice;
            name[4] = "@ProductSalePrice"; value[4] = productEntity.ProductSalePrice;
            name[5] = "@ProductManufactureDate"; value[5] = productEntity.ProductManufactureDate;
            name[6] = "@ProductExpiryDate"; value[6] = productEntity.ProductExpiryDate;
            name[7] = "@ProductDateAdded"; value[7] = productEntity.ProductImportDate;
            name[8] = "@VAT"; value[8] = productEntity.VAT;
            name[9] = "@ProductImage"; value[9] = productEntity.ProductImage;
            name[10] = "@ProductID"; value[10] = productEntity.ProductID;

            return connect.Update("sp_Product_Update", name, value, param);
        }

        /// <summary>
        /// Delete Information Product
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public int ProductDelete(ProductEntity productEntity)
        {
            int param = 1;

            string[] name = new string[param];
            object[] value = new object[param];

            name[0] = "@ProductID";
            value[0] = productEntity.ProductID;

            return connect.Update("sp_Product_Delete", name, value, param);
        }
    }
}
