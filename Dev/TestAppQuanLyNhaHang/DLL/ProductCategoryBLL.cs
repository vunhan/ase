using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.DAL;

namespace TestAppQuanLyNhaHang.DLL
{
    class ProductCategoryBLL
    {
        ProductCategoryDAL categoryDAL = new ProductCategoryDAL();
        public DataTable ProductLoadAll()
        {
            return categoryDAL.CategoryLoadAll();
        }
    }
}
