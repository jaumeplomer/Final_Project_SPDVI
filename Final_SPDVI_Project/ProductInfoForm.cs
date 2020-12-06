using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_SPDVI_Project
{
    public partial class ProductInfoForm : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorksDB"].ConnectionString;
        public static string infoProductName = "";
        public static string safeInfoProductName;
        public ProductInfoForm()
        {
            InitializeComponent();           
        }
        public ProductInfoForm(string info)
        {
            InitializeComponent();
            infoProductName = info;
            safeInfoProductName = infoProductName.Replace("'", "''");
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description,
                            Production.Product.Name AS ProductName, Production.Product.ProductNumber AS ProNumber, Production.Product.Color AS Color, Production.Product.ListPrice AS Price, Production.Product.Size AS Size,
                            Production.Product.ProductLine AS ProLine, Production.Product.Class AS Clase, Production.Product.Style AS Style,
                            Production.ProductCategory.Name AS Cat,
                            Production.ProductSubcategory.Name AS SubCat
                            FROM
                            Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductModel.Name = '{safeInfoProductName}'";
                models = connection.Query<Model>(sql).ToList();
                Model model = new Model();
                model = models[0];
               
                textBoxProductModelName.Text = model.Name;
                textBoxProductModelDesc.Text = model.Description;

                textBoxProductName.Text = model.ProductName;
                textBoxProNumber.Text = model.ProNumber;
                textBoxColor.Text = model.Color;
                textBoxPrice.Text = (model.priceValue()).ToString();
                textBoxSize.Text = model.Size;
                textBoxProLine.Text = model.ProLine;
                textBoxClass.Text = model.Clase;
                textBoxStyle.Text = model.Style;
                textBoxProductModelCat.Text = model.Cat;
                textBoxProductModelSubCat.Text = model.SubCat;
                
            }
        }
    }
}
