using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAppQuanLyNhaHang.GUI
{
    class ProductEntity : ProductTypeEntiny
    {
        public string ProductID { get; set; }
        public string UnitID { get; set; }
        public string SupplierID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductBuyPrice { get; set; }
        public decimal ProductSalePrice { get; set; }
        public DateTime ProductManufactureDate { get; set; }
        public DateTime ProductExpiryDate { get; set; }
        public DateTime ProductImportDate { get; set; }
        public double VAT { get; set; }
        public byte[] ProductImage { get; set; }
    }
}
