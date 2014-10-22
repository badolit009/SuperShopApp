using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperShopApp.DAL.DAO;

namespace SuperShopApp.DAL.Gateway
{
    class ProductGateway
    {
          private SqlConnection connection;
          public ProductGateway()
        {
            connection=new SqlConnection(ConfigurationManager.ConnectionStrings["sqlcon"].ConnectionString);
        }
        public string Save(Product aProduct)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Product VALUES ('{0}','{1}',{2})", aProduct.Code, aProduct.Name, aProduct.Quantity);
            SqlCommand cmd = new SqlCommand(query, connection);
            int affectedrow = cmd.ExecuteNonQuery();
            connection.Close();
            if (affectedrow > 0)
            {
                return "Product Insert Successfully";
            }
            return "Product Insert Failed";
            
        }
        public List<Product> GetAllProduct()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Product");
            SqlCommand command = new SqlCommand(query, connection);
            List<Product> aProducts = new List<Product>();
            SqlDataReader aReader = command.ExecuteReader();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Product aProduct = new Product();
                    aProduct.Id = (int) aReader[0];
                    aProduct.Code = aReader[1].ToString();
                    aProduct.Name = aReader[2].ToString();
                    aProduct.Quantity = (int) aReader[3];
                    aProducts.Add(aProduct);
                }
            }
            connection.Close();
            return aProducts;
        }

        public bool HasThisName(string name)
        {
            connection.Open();
            string query = "SELECT *FROM t_Product WHERE Name=@0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0",name);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public bool HasThisCode(string code)
        {
            connection.Open();
            string query = "SELECT *FROM t_Product WHERE Code=@0";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", code);
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public int TotalQuantity()
        {
            connection.Open();
            string query = "SELECT SUM(Quantity) AS TotalQuantity FROM t_Product";
            SqlCommand command = new SqlCommand(query, connection);
            object totalQuantity= command.ExecuteScalar();
            connection.Close();
            return (int) totalQuantity;
        }
    }
}
