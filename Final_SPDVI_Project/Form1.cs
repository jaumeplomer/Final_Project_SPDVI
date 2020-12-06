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
    public partial class listViewProducts : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["AdventureWorksDB"].ConnectionString;
        public static string language = "en";
        public static float min = 0;
        public static float max = 4000;
        public static string onlyAvailableSql = "";
        public static string extraInfo = "";
        public listViewProducts() 
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxLanguage.SelectedItem = "en";
            List<String> categories = new List<string>();
            categories = getCategories();
            foreach (String categoria in categories)
            {
                comboBoxCategoria.Items.Add(categoria);
            }         
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Model> models = new List<Model>();
            models = GetModels();
            foreach (Model model in models)
            {
                listView1.Items.Add(model.ToString());
            }
            comboBoxCategoria.Text = "";
            comboBoxSubCategoria.Text = "";
            comboBoxStyle.Text = "";
            comboBoxSize.Text = "";
            comboBoxProductLine.Text = "";
            comboBoxClass.Text = "";
            textBoxFindByModelName.Text = "";
            textBoxFindByProductName.Text = "";
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            language = comboBoxLanguage.Text;
        }

        private void comboBoxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM
                            Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductCategory.Name = '{comboBoxCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }

                comboBoxSubCategoria.Items.Clear();
                List<String> subcategories = new List<string>();
                subcategories = getSubCategories();
                foreach (String subcategoria in subcategories)
                {
                    comboBoxSubCategoria.Items.Add(subcategoria);
                }
            }
        }

        private void comboBoxSubCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM
                            Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
    
                comboBoxStyle.Items.Clear();
                List<String> styles = new List<string>();
                styles = getStyle();
                foreach (String style in styles)
                {
                    if (style != null)
                    {
                        comboBoxStyle.Items.Add(style);
                    }
                }

                comboBoxSize.Items.Clear();
                List<String> sizes = new List<string>();
                sizes = getSize();
                foreach (String size in sizes)
                {
                    if (size != null)
                    {
                        comboBoxSize.Items.Add(size);
                    }
                }

                comboBoxProductLine.Items.Clear();
                List<String> productLines = new List<string>();
                productLines = getProductLine();
                foreach (String productLine in productLines)
                {
                    if (productLine != null)
                    {
                        comboBoxProductLine.Items.Add(productLine);
                    }
                }

                comboBoxClass.Items.Clear();
                List<String> classes = new List<string>();
                classes = getClasses();
                foreach (String clase in classes)
                {
                    if (clase != null)
                    {
                        comboBoxClass.Items.Add(clase);
                    }
                }
            }
        }

        private void comboBoxStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}'
                            AND Production.Product.Style = '{comboBoxStyle.SelectedItem}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
                comboBoxSize.Text = "";
                comboBoxProductLine.Text = "";
                comboBoxClass.Text = "";
            }
        }

        private void comboBoxSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}'
                            AND Production.Product.Size = '{comboBoxSize.SelectedItem}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
                comboBoxStyle.Text = "";
                comboBoxProductLine.Text = "";
                comboBoxClass.Text = "";
            }
        }

        private void comboBoxProductLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}'
                            AND Production.Product.ProductLine = '{comboBoxProductLine.SelectedItem}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
                comboBoxStyle.Text = "";
                comboBoxSize.Text = "";
                comboBoxClass.Text = "";
            }
        }
        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}'
                            AND Production.Product.Class = '{comboBoxClass.SelectedItem}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
                comboBoxStyle.Text = "";
                comboBoxSize.Text = "";
                comboBoxProductLine.Text = "";
            }
        }

        private void minPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            min = float.Parse(minPriceTextBox.Text);
        }

        private void maxPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            max = float.Parse(maxPriceTextBox.Text);
        }

        private void applyPriceFilterButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}' AND ProductModelProductDescriptionCulture.CultureID = '{language}'
                            AND Production.Product.ListPrice BETWEEN {min} AND {max} {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
            }
        }
        private void textBoxFindByProductName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM
                            Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.Product.Name  LIKE '{textBox.Text}%' AND ProductModelProductDescriptionCulture.CultureID = '{language}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
            }
        }

        private void textBoxFindByModelName_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            listView1.Items.Clear();
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT
                            Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM
                            Production.Product
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID
                            WHERE Production.ProductModel.Name  LIKE '{textBox.Text}%' AND ProductModelProductDescriptionCulture.CultureID = '{language}' {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                foreach (Model model in models)
                {
                    listView1.Items.Add(model.ToString());
                }
            }
        }
   
        private void availableProductsButton_Click(object sender, EventArgs e)
        {
            onlyAvailableSql = "AND Production.Product.SellEndDate IS NULL";
            extraInfo = "";
        }

        private void allProductsButton_Click(object sender, EventArgs e)
        {
            onlyAvailableSql = "";
            extraInfo = ", Production.Product.SellStartDate, Production.Product.SellEndDate";
        }

        public static List<Model> GetModels()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<Model> models = new List<Model>();
                string sql = $@"SELECT DISTINCT Production.ProductModel.Name, Production.ProductDescription.Description{extraInfo}
                            FROM Production.Product 
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID 
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID 
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID 
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID 
                            WHERE ProductModelProductDescriptionCulture.CultureID = '{language}' AND Product.ProductModelID IS NOT NULL {onlyAvailableSql}";
                models = connection.Query<Model>(sql).ToList();
                return models;
            }
        }

        public static List<String> getCategories()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> categories = new List<string>();
                string sql = @"SELECT Production.ProductCategory.Name, Production.ProductCategory.ProductCategoryID 
                             FROM Production.ProductCategory ORDER BY Production.ProductCategory.ProductCategoryID ASC";
                categories = connection.Query<String>(sql).ToList();
                return categories;
            }
        }

        public List<String> getSubCategories()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> subcategories = new List<string>();
                string sql = $@"SELECT Production.ProductSubcategory.Name FROM Production.ProductSubcategory 
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID
                            WHERE Production.ProductSubcategory.ProductCategoryID = {comboBoxCategoria.SelectedIndex + 1}";
                subcategories = connection.Query<String>(sql).ToList();
                return subcategories;
            }
        }

        public List<String> getStyle()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> styles = new List<string>();
                string sql = $@"SELECT DISTINCT Production.Product.Style FROM Production.Product 
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID 
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID 
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID 
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID 
                            WHERE Product.ProductModelID IS NOT NULL AND Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}'";
                styles = connection.Query<String>(sql).ToList();
                return styles;
            }
        }

        public List<String> getSize()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> sizes = new List<string>();
                string sql = $@"SELECT DISTINCT Production.Product.Size FROM Production.Product 
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID 
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID 
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID 
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID 
                            WHERE Product.ProductModelID IS NOT NULL AND Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}'";
                sizes = connection.Query<String>(sql).ToList();
                return sizes;
            }
        }

        public List<String> getProductLine()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> productLine = new List<string>();
                string sql = $@"SELECT DISTINCT Production.Product.ProductLine FROM Production.Product 
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID 
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID 
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID 
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID 
                            WHERE Product.ProductModelID IS NOT NULL AND Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}'";
                productLine = connection.Query<String>(sql).ToList();
                return productLine;
            }
        }

        public List<String> getClasses()
        {
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<String> classes = new List<string>();
                string sql = $@"SELECT DISTINCT Production.Product.Class FROM Production.Product 
                            INNER JOIN Production.ProductSubcategory ON Production.Product.ProductSubcategoryID = Production.ProductSubcategory.ProductSubcategoryID 
                            INNER JOIN Production.ProductCategory ON Production.ProductSubcategory.ProductCategoryID = Production.ProductCategory.ProductCategoryID 
                            INNER JOIN Production.ProductModel ON Production.Product.ProductModelID = Production.ProductModel.ProductModelID 
                            INNER JOIN Production.ProductModelProductDescriptionCulture ON Production.ProductModel.ProductModelID = Production.ProductModelProductDescriptionCulture.ProductModelID 
                            INNER JOIN Production.ProductDescription ON Production.ProductModelProductDescriptionCulture.ProductDescriptionID = Production.ProductDescription.ProductDescriptionID 
                            WHERE Product.ProductModelID IS NOT NULL AND Production.ProductSubcategory.Name = '{comboBoxSubCategoria.SelectedItem}'";
                classes = connection.Query<String>(sql).ToList();
                return classes;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string info = listView1.SelectedItems[0].Text;
            char separador;
            string[] a = info.Split(separador = '|');          
            ProductInfoForm form = new ProductInfoForm(a[0]);           
            form.Show();
        }
    }
}
