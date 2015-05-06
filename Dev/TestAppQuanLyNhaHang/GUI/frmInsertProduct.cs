using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestAppQuanLyNhaHang.DLL;

namespace TestAppQuanLyNhaHang.GUI
{
    public partial class frmInsertProduct : Form
    {
        ProductCategoryBLL productCategoryBLL = new ProductCategoryBLL();
        ProductTypeBLL productTypeBLL = new ProductTypeBLL();
        UnitBLL unitBLL = new UnitBLL();
        ProductSupplierBLL productSupplierDLL = new ProductSupplierBLL();
        ProductEntity productEntity = new ProductEntity();
        public frmInsertProduct()
        {
            InitializeComponent();
            cbbCategoryLoadAll();
            cbbProductTypeLoadAll();
            cbbUnitLoadAll();
            cbbProductSupplierLoadAll();
        }

        private void cbbCategoryLoadAll()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = productCategoryBLL.ProductLoadAll();
            cbbCategory.DataSource = dtTemp.DefaultView;
            cbbCategory.DisplayMember = "CategoryName";
            cbbCategory.ValueMember = "CategoryName";
            cbbCategory.Enabled = true;
        }

        private void cbbProductTypeLoadAll()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = productTypeBLL.ProductLoadAll();
            cbbProductType.DataSource = dtTemp.DefaultView;
            cbbProductType.DisplayMember = "ProductTypeName";
            cbbProductType.ValueMember = "ProductTypeName";
            cbbProductType.Enabled = true;
        }


        private void cbbUnitLoadAll()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = unitBLL.UnitLoadAll();
            cbbUnit.DataSource = dtTemp.DefaultView;
            cbbUnit.DisplayMember = "UnitName";
            cbbUnit.ValueMember = "UnitName";
            cbbUnit.Enabled = true;
        }

        private void cbbProductSupplierLoadAll()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = productSupplierDLL.ProductLoadAll();
            cbbProductSupplier.DataSource = dtTemp.DefaultView;
            cbbProductSupplier.DisplayMember = "SupplierName";
            cbbProductSupplier.ValueMember = "SupplierName";
            cbbProductSupplier.Enabled = true;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            productEntity.ProductID = "";

        }

      
       
    }
}
