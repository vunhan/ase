using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppQuanLyNhaHang.DAL
{
    class ProductCategoryDAL
    {
        ConnectionDAL connect = new ConnectionDAL();

        /// <summary>
        /// Load all Store information
        /// </summary>
        /// <returns></returns>
        public DataTable CategoryLoadAll()
        {
            return connect.LoadData("sp_Category_GetByAll");
        }
    }
}
