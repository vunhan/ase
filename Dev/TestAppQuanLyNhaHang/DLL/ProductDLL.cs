using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.DAL;

namespace TestAppQuanLyNhaHang.DLL
{
    class ProductDLL
    {
        ProductDAL productDAL = new ProductDAL();
        public DataTable ProductLoadAll()
        {
            return productDAL.ProductLoadAll();
        }

    }
}
