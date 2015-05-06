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
using TestAppQuanLyNhaHang.GUI;

namespace TestAppQuanLyNhaHang
{
    public partial class Form1 : Form
    {
        ProductBLL productDLL = new ProductBLL();
        ProductEntity productEntity = new ProductEntity();
        public Form1()
        {
            InitializeComponent();
            ProductLoadAll();
        }

      private void ProductLoadAll()
        {
            DataTable dtTemp = new DataTable();
            dtTemp = productDLL.ProductLoadAll();
            dataGridView1.DataSource = dtTemp.DefaultView;
           
        }
      /// <summary>
      /// Insert Information to Database
      /// </summary>
      /// <param name="productEntity"></param>
      /// <returns></returns>
    private void ProductInsert(ProductEntity productEntity)
      {
          productDLL.ProductInsert(productEntity);
      }


      private void bntAddProduct_Click(object sender, EventArgs e)
      {
          frmInsertProduct fInsertProduct = new frmInsertProduct();
          fInsertProduct.Show();
      }


     }
}
