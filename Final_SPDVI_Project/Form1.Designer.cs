namespace Final_SPDVI_Project
{
    partial class listViewProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCategoria = new System.Windows.Forms.ComboBox();
            this.labelCategoria = new System.Windows.Forms.Label();
            this.labelSubCategoria = new System.Windows.Forms.Label();
            this.comboBoxSubCategoria = new System.Windows.Forms.ComboBox();
            this.labelSize = new System.Windows.Forms.Label();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.labelProductLine = new System.Windows.Forms.Label();
            this.comboBoxProductLine = new System.Windows.Forms.ComboBox();
            this.labelClass = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.labelStyle = new System.Windows.Forms.Label();
            this.comboBoxStyle = new System.Windows.Forms.ComboBox();
            this.labelListPrice = new System.Windows.Forms.Label();
            this.textBoxFindByName = new System.Windows.Forms.TextBox();
            this.labelFindByName = new System.Windows.Forms.Label();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.comboBoxLanguage = new System.Windows.Forms.ComboBox();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.PRODUCTS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minPriceTextBox = new System.Windows.Forms.TextBox();
            this.minPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceLabel = new System.Windows.Forms.Label();
            this.maxPriceTextBox = new System.Windows.Forms.TextBox();
            this.applyPriceFilterButton = new System.Windows.Forms.Button();
            this.groupBoxFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCategoria
            // 
            this.comboBoxCategoria.FormattingEnabled = true;
            this.comboBoxCategoria.Location = new System.Drawing.Point(21, 45);
            this.comboBoxCategoria.Name = "comboBoxCategoria";
            this.comboBoxCategoria.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCategoria.TabIndex = 1;
            this.comboBoxCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoria_SelectedIndexChanged);
            // 
            // labelCategoria
            // 
            this.labelCategoria.AutoSize = true;
            this.labelCategoria.Location = new System.Drawing.Point(21, 22);
            this.labelCategoria.Name = "labelCategoria";
            this.labelCategoria.Size = new System.Drawing.Size(73, 17);
            this.labelCategoria.TabIndex = 2;
            this.labelCategoria.Text = "Categoria:";
            // 
            // labelSubCategoria
            // 
            this.labelSubCategoria.AutoSize = true;
            this.labelSubCategoria.Location = new System.Drawing.Point(21, 76);
            this.labelSubCategoria.Name = "labelSubCategoria";
            this.labelSubCategoria.Size = new System.Drawing.Size(96, 17);
            this.labelSubCategoria.TabIndex = 4;
            this.labelSubCategoria.Text = "Subcategoria:";
            // 
            // comboBoxSubCategoria
            // 
            this.comboBoxSubCategoria.FormattingEnabled = true;
            this.comboBoxSubCategoria.Location = new System.Drawing.Point(21, 99);
            this.comboBoxSubCategoria.Name = "comboBoxSubCategoria";
            this.comboBoxSubCategoria.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSubCategoria.TabIndex = 3;
            this.comboBoxSubCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategoria_SelectedIndexChanged);
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(21, 130);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(39, 17);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Size:";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Location = new System.Drawing.Point(21, 153);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSize.TabIndex = 5;
            this.comboBoxSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxSize_SelectedIndexChanged);
            // 
            // labelProductLine
            // 
            this.labelProductLine.AutoSize = true;
            this.labelProductLine.Location = new System.Drawing.Point(21, 190);
            this.labelProductLine.Name = "labelProductLine";
            this.labelProductLine.Size = new System.Drawing.Size(88, 17);
            this.labelProductLine.TabIndex = 8;
            this.labelProductLine.Text = "ProductLine:";
            // 
            // comboBoxProductLine
            // 
            this.comboBoxProductLine.FormattingEnabled = true;
            this.comboBoxProductLine.Location = new System.Drawing.Point(21, 213);
            this.comboBoxProductLine.Name = "comboBoxProductLine";
            this.comboBoxProductLine.Size = new System.Drawing.Size(121, 24);
            this.comboBoxProductLine.TabIndex = 7;
            this.comboBoxProductLine.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductLine_SelectedIndexChanged);
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Location = new System.Drawing.Point(21, 250);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(46, 17);
            this.labelClass.TabIndex = 10;
            this.labelClass.Text = "Class:";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(21, 273);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClass.TabIndex = 9;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            // 
            // labelStyle
            // 
            this.labelStyle.AutoSize = true;
            this.labelStyle.Location = new System.Drawing.Point(21, 309);
            this.labelStyle.Name = "labelStyle";
            this.labelStyle.Size = new System.Drawing.Size(43, 17);
            this.labelStyle.TabIndex = 12;
            this.labelStyle.Text = "Style:";
            // 
            // comboBoxStyle
            // 
            this.comboBoxStyle.FormattingEnabled = true;
            this.comboBoxStyle.Location = new System.Drawing.Point(21, 332);
            this.comboBoxStyle.Name = "comboBoxStyle";
            this.comboBoxStyle.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStyle.TabIndex = 11;
            this.comboBoxStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxStyle_SelectedIndexChanged);
            // 
            // labelListPrice
            // 
            this.labelListPrice.AutoSize = true;
            this.labelListPrice.Location = new System.Drawing.Point(18, 369);
            this.labelListPrice.Name = "labelListPrice";
            this.labelListPrice.Size = new System.Drawing.Size(66, 17);
            this.labelListPrice.TabIndex = 14;
            this.labelListPrice.Text = "ListPrice:";
            // 
            // textBoxFindByName
            // 
            this.textBoxFindByName.Location = new System.Drawing.Point(21, 482);
            this.textBoxFindByName.Name = "textBoxFindByName";
            this.textBoxFindByName.Size = new System.Drawing.Size(171, 22);
            this.textBoxFindByName.TabIndex = 15;
            // 
            // labelFindByName
            // 
            this.labelFindByName.AutoSize = true;
            this.labelFindByName.Location = new System.Drawing.Point(21, 462);
            this.labelFindByName.Name = "labelFindByName";
            this.labelFindByName.Size = new System.Drawing.Size(97, 17);
            this.labelFindByName.TabIndex = 16;
            this.labelFindByName.Text = "Find by name:";
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.groupBoxFilters.Controls.Add(this.applyPriceFilterButton);
            this.groupBoxFilters.Controls.Add(this.maxPriceLabel);
            this.groupBoxFilters.Controls.Add(this.maxPriceTextBox);
            this.groupBoxFilters.Controls.Add(this.minPriceLabel);
            this.groupBoxFilters.Controls.Add(this.minPriceTextBox);
            this.groupBoxFilters.Controls.Add(this.comboBoxCategoria);
            this.groupBoxFilters.Controls.Add(this.labelFindByName);
            this.groupBoxFilters.Controls.Add(this.labelCategoria);
            this.groupBoxFilters.Controls.Add(this.textBoxFindByName);
            this.groupBoxFilters.Controls.Add(this.comboBoxSubCategoria);
            this.groupBoxFilters.Controls.Add(this.labelListPrice);
            this.groupBoxFilters.Controls.Add(this.labelSubCategoria);
            this.groupBoxFilters.Controls.Add(this.comboBoxSize);
            this.groupBoxFilters.Controls.Add(this.labelStyle);
            this.groupBoxFilters.Controls.Add(this.labelSize);
            this.groupBoxFilters.Controls.Add(this.comboBoxStyle);
            this.groupBoxFilters.Controls.Add(this.comboBoxProductLine);
            this.groupBoxFilters.Controls.Add(this.labelClass);
            this.groupBoxFilters.Controls.Add(this.labelProductLine);
            this.groupBoxFilters.Controls.Add(this.comboBoxClass);
            this.groupBoxFilters.Location = new System.Drawing.Point(31, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(247, 523);
            this.groupBoxFilters.TabIndex = 17;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Filters:";
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(302, 476);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(185, 59);
            this.buttonLoadData.TabIndex = 18;
            this.buttonLoadData.Text = "Load All Data";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // comboBoxLanguage
            // 
            this.comboBoxLanguage.FormattingEnabled = true;
            this.comboBoxLanguage.Items.AddRange(new object[] {
            "en",
            "fr"});
            this.comboBoxLanguage.Location = new System.Drawing.Point(377, 12);
            this.comboBoxLanguage.Name = "comboBoxLanguage";
            this.comboBoxLanguage.Size = new System.Drawing.Size(121, 24);
            this.comboBoxLanguage.TabIndex = 19;
            this.comboBoxLanguage.SelectedIndexChanged += new System.EventHandler(this.comboBoxLanguage_SelectedIndexChanged);
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(299, 19);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(72, 17);
            this.labelLanguage.TabIndex = 20;
            this.labelLanguage.Text = "Language";
            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listView1.AutoArrange = false;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PRODUCTS});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(302, 57);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 413);
            this.listView1.TabIndex = 21;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // PRODUCTS
            // 
            this.PRODUCTS.Text = "PRODUCTS:";
            this.PRODUCTS.Width = 600;
            // 
            // minPriceTextBox
            // 
            this.minPriceTextBox.Location = new System.Drawing.Point(21, 406);
            this.minPriceTextBox.Name = "minPriceTextBox";
            this.minPriceTextBox.Size = new System.Drawing.Size(63, 22);
            this.minPriceTextBox.TabIndex = 17;
            this.minPriceTextBox.TextChanged += new System.EventHandler(this.minPriceTextBox_TextChanged);
            // 
            // minPriceLabel
            // 
            this.minPriceLabel.AutoSize = true;
            this.minPriceLabel.Location = new System.Drawing.Point(18, 386);
            this.minPriceLabel.Name = "minPriceLabel";
            this.minPriceLabel.Size = new System.Drawing.Size(34, 17);
            this.minPriceLabel.TabIndex = 18;
            this.minPriceLabel.Text = "Min.";
            // 
            // maxPriceLabel
            // 
            this.maxPriceLabel.AutoSize = true;
            this.maxPriceLabel.Location = new System.Drawing.Point(90, 386);
            this.maxPriceLabel.Name = "maxPriceLabel";
            this.maxPriceLabel.Size = new System.Drawing.Size(37, 17);
            this.maxPriceLabel.TabIndex = 20;
            this.maxPriceLabel.Text = "Max.";
            // 
            // maxPriceTextBox
            // 
            this.maxPriceTextBox.Location = new System.Drawing.Point(90, 406);
            this.maxPriceTextBox.Name = "maxPriceTextBox";
            this.maxPriceTextBox.Size = new System.Drawing.Size(65, 22);
            this.maxPriceTextBox.TabIndex = 19;
            this.maxPriceTextBox.TextChanged += new System.EventHandler(this.maxPriceTextBox_TextChanged);
            // 
            // applyPriceFilterButton
            // 
            this.applyPriceFilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.applyPriceFilterButton.Location = new System.Drawing.Point(161, 386);
            this.applyPriceFilterButton.Name = "applyPriceFilterButton";
            this.applyPriceFilterButton.Size = new System.Drawing.Size(75, 42);
            this.applyPriceFilterButton.TabIndex = 21;
            this.applyPriceFilterButton.Text = "Apply";
            this.applyPriceFilterButton.UseVisualStyleBackColor = false;
            this.applyPriceFilterButton.Click += new System.EventHandler(this.applyPriceFilterButton_Click);
            // 
            // listViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 582);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelLanguage);
            this.Controls.Add(this.comboBoxLanguage);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.groupBoxFilters);
            this.Name = "listViewProducts";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxCategoria;
        private System.Windows.Forms.Label labelCategoria;
        private System.Windows.Forms.Label labelSubCategoria;
        private System.Windows.Forms.ComboBox comboBoxSubCategoria;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label labelProductLine;
        private System.Windows.Forms.ComboBox comboBoxProductLine;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label labelStyle;
        private System.Windows.Forms.ComboBox comboBoxStyle;
        private System.Windows.Forms.Label labelListPrice;
        private System.Windows.Forms.TextBox textBoxFindByName;
        private System.Windows.Forms.Label labelFindByName;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.ComboBox comboBoxLanguage;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader PRODUCTS;
        private System.Windows.Forms.Label maxPriceLabel;
        private System.Windows.Forms.TextBox maxPriceTextBox;
        private System.Windows.Forms.Label minPriceLabel;
        private System.Windows.Forms.TextBox minPriceTextBox;
        private System.Windows.Forms.Button applyPriceFilterButton;
    }
}

