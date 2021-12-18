using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using AntichitaPischetola2.Models;
using Microsoft.AspNetCore.Mvc;

namespace AntichitaPischetola2.Services
{
    public class IProductsDAO : IProductDataService
    {
        string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AntichitaPischetola;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public int Delete(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> GetAllProducts()
        {
            List<ProductsModel> foundProducts = new List<ProductsModel>();

            string query = "select * from Products";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand(query, con);
                try
                {
                    con.Open();

                    SqlDataReader reader = com.ExecuteReader();
                    while (reader.Read())
                    {
                        foundProducts.Add(new ProductsModel { Id = (int)reader[0], ProductName = (string)reader[1], 
                            Description = (string)reader[2], CategoryId = (int)reader[3], ModelYear = (DateTime)reader[4], ProductHeight = (decimal)reader[5],
                            ProductWidth = (decimal)reader[6], IsAvailable = (int)reader[7], DateAdded = (DateTime)reader[8], Url1 = (string)reader[9], 
                            Url2 = (string)reader[10], Url3 = (string)reader[11],Url4 = (string)reader[12]
                        });
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                return foundProducts;
            }
        }

        public ProductsModel GetProductByID(int Id)
        {
            throw new NotImplementedException();
        }

        public int Insert(ProductsModel product)
        {
            throw new NotImplementedException();
        }

        public List<ProductsModel> SearchProducts(string searchTerm)
        {
            throw new NotImplementedException();
        }

        public int Update(ProductsModel product)
        {
            throw new NotImplementedException();
        }
    }
}
