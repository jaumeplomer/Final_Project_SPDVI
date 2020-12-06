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
        public static Model modelInfo;
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

        public ProductInfoForm(Model model)
        {
            InitializeComponent();
            modelInfo =  model; 
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                //List<Model> models = new List<Model>();
                //string sql = $@"SELECT
                //            Production.ProductModel.Name, Production.ProductDescription.Description,
                //            Production.Product.Name AS ProductName, Production.Product.ProductNumber AS ProNumber, Production.Product.Color AS Color, Production.Product.ListPrice AS Price, Production.Product.Size AS Size,
                //            Production.Product.ProductLine AS ProLine, Production.Product.Class AS Clase, Production.Product.Style AS Style,
                //            Production.ProductCategory.Name AS Cat,
                //            Production.ProductSubcategory.Name AS SubCat
                //            FROM
                //            Production.Product
                //            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                //            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                //            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                //            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                //            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                //            WHERE Production.ProductModel.Name = '{safeInfoProductName}'";
                //models = connection.Query<Model>(sql).ToList();
                //Model model = new Model();
                //model = models[0];
               
                textBoxProductModelName.Text = modelInfo.Name;
                textBoxProductModelDesc.Text = modelInfo.Description;

                textBoxProductName.Text = modelInfo.ProductName;
                textBoxProNumber.Text = modelInfo.ProNumber;
                textBoxColor.Text = modelInfo.Color;
                textBoxPrice.Text = (modelInfo.priceValue()).ToString();
                textBoxSize.Text = modelInfo.Size;
                textBoxProLine.Text = modelInfo.ProLine;
                textBoxClass.Text = modelInfo.Clase;
                textBoxStyle.Text = modelInfo.Style;
                textBoxProductModelCat.Text = modelInfo.Cat;
                textBoxProductModelSubCat.Text = modelInfo.SubCat;
                
            }
        }
    }
}
