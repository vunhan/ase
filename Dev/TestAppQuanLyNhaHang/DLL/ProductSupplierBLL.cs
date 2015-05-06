using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.DAL;

namespace TestAppQuanLyNhaHang.DLL
{
    class ProductSupplierBLL
    {
        ProductSupplierDAL productSupplierDAL = new ProductSupplierDAL();
        public DataTable ProductLoadAll()
        {
            return productSupplierDAL.ProductSupplieroadAll();
        }
    }
}
