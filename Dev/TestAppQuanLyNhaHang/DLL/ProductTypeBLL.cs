using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.DAL;

namespace TestAppQuanLyNhaHang.DLL
{
    class ProductTypeBLL
    {
        ProductTypeDAL productTypeDAL = new ProductTypeDAL();
        public DataTable ProductLoadAll()
        {
            return productTypeDAL.ProductTypeLoadAll();
        }
    }
}
