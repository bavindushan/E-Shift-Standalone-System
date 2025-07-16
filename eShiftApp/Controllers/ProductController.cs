using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using eShiftApp.Models;
using eShiftApp.Utils;

namespace eShiftApp.Controllers
{
    public class ProductController
    {
        // Add new product
        public int AddProduct(Product product)
        {
            string query = "INSERT INTO Product (name, description) VALUES (@Name, @Description)";

            SqlParameter[] parameters = {
                new SqlParameter("@Name", product.Name),
                new SqlParameter("@Description", product.Description)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Get all products
        public List<Product> GetAllProducts()
        {
            string query = "SELECT * FROM Product";
            DataTable dt = DBHelper.ExecuteSelect(query);
            List<Product> products = new List<Product>();

            foreach (DataRow row in dt.Rows)
            {
                products.Add(new Product
                {
                    ProductId = (int)row["product_id"],
                    Name = row["name"].ToString(),
                    Description = row["description"].ToString()
                });
            }

            return products;
        }

        // Update product
        public int UpdateProduct(Product product)
        {
            string query = "UPDATE Product SET name = @Name, description = @Description WHERE product_id = @ProductId";

            SqlParameter[] parameters = {
                new SqlParameter("@Name", product.Name),
                new SqlParameter("@Description", product.Description),
                new SqlParameter("@ProductId", product.ProductId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }

        // Delete product (optional)
        public int DeleteProduct(int productId)
        {
            string query = "DELETE FROM Product WHERE product_id = @ProductId";

            SqlParameter[] parameters = {
                new SqlParameter("@ProductId", productId)
            };

            return DBHelper.ExecuteQuery(query, parameters);
        }
    }
}
