using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopApp.BLL;
using SuperShopApp.DAL.DAO;

namespace SuperShopApp
{
    public partial class SuperShopUI : Form
    {
        public SuperShopUI()
        {
            InitializeComponent();
        }

        private ProductBLL aProductBll = new ProductBLL();
        private void saveButton_Click(object sender, EventArgs e)
        {
            Product aProduct = new Product(codeTextBox.Text,nameTextBox.Text,Convert.ToInt32(quantityTextBox.Text));
            
            string msg = aProductBll.Save(aProduct);
            MessageBox.Show(msg);

        }

        private void viewAllButton_Click(object sender, EventArgs e)
        {
            GetAllProduct();
            totalQuantityTextBox.Text = aProductBll.TotalQuantity().ToString();
        }

        private void GetAllProduct()
        {
            
            List<Product> aProducts = aProductBll.GetAllProduct();
            foreach (Product aProduct in aProducts)
            {
                
                ListViewItem item = new ListViewItem(aProduct.Code);
                item.SubItems.Add(aProduct.Name);
                item.SubItems.Add(aProduct.Quantity.ToString());
                productListView.Items.Add(item);
                
            }
        }
    }
}
