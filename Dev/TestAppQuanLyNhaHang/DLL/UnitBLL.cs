using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAppQuanLyNhaHang.DAL;

namespace TestAppQuanLyNhaHang.DLL
{
    class UnitBLL
    {
        UnitDAL unitDAL = new UnitDAL();
        public DataTable UnitLoadAll()
        {
            return unitDAL.UnitLoadAll();
        }
    }
}
