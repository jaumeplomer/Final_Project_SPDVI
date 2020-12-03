using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_SPDVI_Project
{
    public static class DataAccess
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorksDB"].ConnectionString;
        public static List<Model> GetModels()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = "SELECT Production.ProductModel.Name, Production.ProductDescription.Description FROM Production.Product INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID WHERE ProductModelProductDescriptionCulture.CultureID = 'en' AND Product.ProductModelID IS NOT NULL";
                models = connection.Query<Model>(sql).ToList();
                return models;
            }
        }

        public static List<String> getCategories()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> categories = new List<string>();
                string sql = "SELECT Production.ProductCategory.Name From Production.ProductCategory";
                categories = connection.Query<String>(sql).ToList();
                return categories;
            }
        }

        public static List<String> getSubCategories()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> subcategories = new List<string>();
                string sql = "SELECT Production.ProductSubcategory.Name From Production.ProductSubcategory";
                subcategories = connection.Query<String>(sql).ToList();
                return subcategories;
            }
        }
    }
}
