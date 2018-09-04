using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using ADOCRUDApplication.Models;

namespace DAL
{
    public class DBOperations : IDBOperations
    {
        private SqlCommand sqlCommand;
        private SqlConnection sqlConnection;
        private SqlDataAdapter sqlDataAdapter;

        private const string ConnectionString = "Data Source=192.168.12.20;Initial Catalog=training2018;User ID=usr_2018;Password=pwd@123";

        public IEnumerable<Product> GetProducts()
        {
            using (sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM tblProduct ", sqlConnection);
                var dataReader = sqlCommand.ExecuteReader();

                var products = new List<Product>();

                while (dataReader.Read())
                {
                    products.Add(new Product
                    {
                        ProductID = Convert.ToInt32(dataReader["ProductID"]),
                        ProductName = Convert.ToString(dataReader["ProductName"]),
                        ProductCategoryID = Convert.ToInt32(dataReader["ProductCategoryID"]),
                        ProductPrice = Convert.ToInt32(dataReader["ProductPrice"]),
                        DateCreated = Convert.ToDateTime(dataReader["DateCreated"])
                    });
                }

                return products;
            }
        }

        public int AddProduct(Product product)
        {
            using (sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("INSERT INTO tblProduct (ProductName, ProductPrice, ProductCategoryID, DateCreated) VALUES (@ProductName, @ProductPrice, @ProductCategoryID, @DateCreated)", sqlConnection);

                sqlCommand.Parameters.AddWithValue("@ProductName", product.ProductName);
                sqlCommand.Parameters.AddWithValue("@ProductPrice", product.ProductPrice);
                sqlCommand.Parameters.AddWithValue("@ProductCategoryID", product.ProductCategoryID);
                sqlCommand.Parameters.AddWithValue("@DateCreated", DateTime.Now.Date);

                var rowsAffected = sqlCommand.ExecuteNonQuery();

                return rowsAffected;
            }
        }

        public int UpdateProduct(Product product)
        {
            using (sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();

                sqlCommand = new SqlCommand("UPDATE tblProduct SET ProductName ='" + product.ProductName + "', ProductPrice = " + product.ProductPrice + ", ProductCategoryID =" + product.ProductCategoryID + ", DateCreated ='" + DateTime.Now + "' where ProductID =" + product.ProductID, sqlConnection);

                var rowsAffected = sqlCommand.ExecuteNonQuery();

                return rowsAffected;
            }
        }

        public int DeleteProduct(int productID)
        {
            using (sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("DELETE FROM tblProduct WHERE ProductID = " + productID, sqlConnection);
                var dataReader = sqlCommand.ExecuteReader();
                return dataReader.RecordsAffected;
            }
        }

        public Product GetProductByID(int productID)
        {
            using (sqlConnection = new SqlConnection(ConnectionString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("SELECT * FROM tblProduct WHERE ProductID =" + productID, sqlConnection);

                var dataReader = sqlCommand.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    return new Product
                    {
                        ProductID = Convert.ToInt32(dataReader["ProductID"]),
                        ProductName = Convert.ToString(dataReader["ProductName"]),
                        ProductPrice = Convert.ToInt32(dataReader["ProductPrice"]),
                        ProductCategoryID = Convert.ToInt32(dataReader["ProductCategoryID"]),
                        DateCreated = Convert.ToDateTime(dataReader["DateCreated"])
                    };
                }
                else
                {
                    return null;
                }
            }
        }

        public IEnumerable<Product> Search(SearchProperties searchProperties)
        {
            var products = GetProducts();
            IEnumerable<Product> searchResult = (from product in products
                where (product.ProductName.ToLower().Contains(searchProperties.SearchValue.ToLower()) || searchProperties.SearchValue == null) && product.ProductPrice >= searchProperties.Min && product.ProductPrice <= searchProperties.Max && product.ProductCategoryID == searchProperties.CategoryID
                select product).ToList();

            return searchResult;
        }
    }
}

