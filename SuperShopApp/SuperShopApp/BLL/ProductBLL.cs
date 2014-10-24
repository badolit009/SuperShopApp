using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SuperShopApp.DAL.DAO;
using SuperShopApp.DAL.Gateway;

namespace SuperShopApp.BLL
{
    class ProductBLL
    {
        private ProductGateway aProductGateway = new ProductGateway();
        public string Save(Product aProduct)
        {
            String msg = "";
                if (aProduct.Code.Length > 3 || aProduct.Code.Length < 3)
                {
                    msg += "Plz Product Code 3 Character \n";
                }
                if (aProduct.Name.Length < 5 || aProduct.Name.Length > 10)
                {
                    msg += "Plz Product Name 5-10 character\n";
                }

            if (HasThisCode(aProduct.Code) || HasThisName(aProduct.Name))
                {
                    if (HasThisCode(aProduct.Code))
                    {
                        msg += "Code Is Already Exits In System\n";
                    }
                    if (HasThisName(aProduct.Name))
                    {
                        msg += "\nName Is Already Exits In System";
                    }
                }
            
            else
            {
                return aProductGateway.Save(aProduct);
            }
            return msg;
            }
        private bool HasThisName(string name)
        {
            return aProductGateway.HasThisName(name);
        }
        private bool HasThisCode(string code)
        {
            return aProductGateway.HasThisCode(code);
        }


        public List<Product> GetAllProduct()
        {
            return aProductGateway.GetAllProduct();
        }

        public int TotalQuantity()
        {
            return aProductGateway.TotalQuantity();
        }
    }
}
