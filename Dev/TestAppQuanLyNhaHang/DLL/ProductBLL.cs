using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.DAL;
using TestAppQuanLyNhaHang.GUI;

namespace TestAppQuanLyNhaHang.DLL
{
    class ProductBLL
    {
        ProductDAL productDAL = new ProductDAL();
        public DataTable ProductLoadAll()
        {
            return productDAL.ProductLoadAll();
        }

        /// <summary>
        /// Insert Information Product
        /// </summary>
        /// <param name="productEntity"></param>
        /// <returns></returns>
        public int ProductInsert(ProductEntity productEntity)
        {
            return productDAL.ProductInsert(productEntity);
        }

    }
}
