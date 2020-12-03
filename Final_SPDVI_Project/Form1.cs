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

        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            //productsListBox.Items = DataAccess.GetModels();
            List<Model> models = new List<Model>();
            models = DataAccess.GetModels();
            foreach (Model model in models)
            {
                productsListBox.Items.Add(model.ToString());
            }
        }
    }
}
