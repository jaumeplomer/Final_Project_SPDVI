using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_SPDVI_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<String> categories = new List<string>();
            categories = DataAccess.getCategories();
            foreach (String categoria in categories)
            {
                comboBoxCategoria.Items.Add(categoria);
            }

            List<String> subcategories = new List<string>();
            subcategories = DataAccess.getSubCategories();
            foreach (String subcategoria in subcategories)
            {
                comboBoxSubCategoria.Items.Add(subcategoria);
            }
        }

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            productsListBox.Items.Clear();
            List<Model> models = new List<Model>();
            models = DataAccess.GetModels();
            foreach (Model model in models)
            {
                productsListBox.Items.Add(model.ToString());
            }
        }
    }
}
