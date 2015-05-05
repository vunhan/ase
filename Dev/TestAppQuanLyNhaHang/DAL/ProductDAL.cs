using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
