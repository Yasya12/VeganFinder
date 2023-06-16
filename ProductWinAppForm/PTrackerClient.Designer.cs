namespace ProductWinAppForm
{
    partial class PTrackerClient
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFind = new System.Windows.Forms.TabPage();
            this.comboBoxFProducts = new System.Windows.Forms.ComboBox();
            this.labelRReview = new System.Windows.Forms.Label();
            this.labelPIngredient = new System.Windows.Forms.Label();
            this.textBoxRReview = new System.Windows.Forms.TextBox();
            this.textBoxPIngredients = new System.Windows.Forms.TextBox();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.tabPageAdd = new System.Windows.Forms.TabPage();
            this.labelCName = new System.Windows.Forms.Label();
            this.labelCPrice = new System.Windows.Forms.Label();
            this.labelCIng = new System.Windows.Forms.Label();
            this.labelCReview = new System.Windows.Forms.Label();
            this.buttonCAdd = new System.Windows.Forms.Button();
            this.comboBoxPCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxPCompany = new System.Windows.Forms.ComboBox();
            this.labelCCompany = new System.Windows.Forms.Label();
            this.labelCCategory = new System.Windows.Forms.Label();
            this.textBoxPReview = new System.Windows.Forms.TextBox();
            this.textBoxPPrice = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageFind.SuspendLayout();
            this.tabPageAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFind);
            this.tabControl1.Controls.Add(this.tabPageAdd);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageFind
            // 
            this.tabPageFind.Controls.Add(this.comboBoxFProducts);
            this.tabPageFind.Controls.Add(this.labelRReview);
            this.tabPageFind.Controls.Add(this.labelPIngredient);
            this.tabPageFind.Controls.Add(this.textBoxRReview);
            this.tabPageFind.Controls.Add(this.textBoxPIngredients);
            this.tabPageFind.Controls.Add(this.buttonProducts);
            this.tabPageFind.Controls.Add(this.textBoxSearch);
            this.tabPageFind.Controls.Add(this.listBoxProducts);
            this.tabPageFind.Location = new System.Drawing.Point(4, 29);
            this.tabPageFind.Name = "tabPageFind";
            this.tabPageFind.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFind.Size = new System.Drawing.Size(789, 414);
            this.tabPageFind.TabIndex = 0;
            this.tabPageFind.Text = "Find";
            this.tabPageFind.UseVisualStyleBackColor = true;
            // 
            // comboBoxFProducts
            // 
            this.comboBoxFProducts.FormattingEnabled = true;
            this.comboBoxFProducts.Location = new System.Drawing.Point(26, 83);
            this.comboBoxFProducts.Name = "comboBoxFProducts";
            this.comboBoxFProducts.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFProducts.TabIndex = 7;
            // 
            // labelRReview
            // 
            this.labelRReview.AutoSize = true;
            this.labelRReview.Location = new System.Drawing.Point(420, 273);
            this.labelRReview.Name = "labelRReview";
            this.labelRReview.Size = new System.Drawing.Size(50, 20);
            this.labelRReview.TabIndex = 6;
            this.labelRReview.Text = "Відгук";
            this.labelRReview.Visible = false;
            // 
            // labelPIngredient
            // 
            this.labelPIngredient.AutoSize = true;
            this.labelPIngredient.Location = new System.Drawing.Point(420, 128);
            this.labelPIngredient.Name = "labelPIngredient";
            this.labelPIngredient.Size = new System.Drawing.Size(49, 20);
            this.labelPIngredient.TabIndex = 5;
            this.labelPIngredient.Text = "Склад";
            this.labelPIngredient.Visible = false;
            // 
            // textBoxRReview
            // 
            this.textBoxRReview.Location = new System.Drawing.Point(494, 273);
            this.textBoxRReview.Multiline = true;
            this.textBoxRReview.Name = "textBoxRReview";
            this.textBoxRReview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxRReview.Size = new System.Drawing.Size(259, 118);
            this.textBoxRReview.TabIndex = 4;
            this.textBoxRReview.Visible = false;
            // 
            // textBoxPIngredients
            // 
            this.textBoxPIngredients.Location = new System.Drawing.Point(494, 125);
            this.textBoxPIngredients.Multiline = true;
            this.textBoxPIngredients.Name = "textBoxPIngredients";
            this.textBoxPIngredients.Size = new System.Drawing.Size(259, 118);
            this.textBoxPIngredients.TabIndex = 3;
            this.textBoxPIngredients.Visible = false;
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(208, 28);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(94, 29);
            this.buttonProducts.TabIndex = 2;
            this.buttonProducts.Text = "Search";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(20, 30);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(148, 27);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(20, 122);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(378, 284);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.Visible = false;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // tabPageAdd
            // 
            this.tabPageAdd.Controls.Add(this.buttonClear);
            this.tabPageAdd.Controls.Add(this.textBoxPReview);
            this.tabPageAdd.Controls.Add(this.textBoxPPrice);
            this.tabPageAdd.Controls.Add(this.textBox1);
            this.tabPageAdd.Controls.Add(this.textBoxPName);
            this.tabPageAdd.Controls.Add(this.comboBoxPCategory);
            this.tabPageAdd.Controls.Add(this.comboBoxPCompany);
            this.tabPageAdd.Controls.Add(this.labelCCompany);
            this.tabPageAdd.Controls.Add(this.labelCCategory);
            this.tabPageAdd.Controls.Add(this.buttonCAdd);
            this.tabPageAdd.Controls.Add(this.labelCReview);
            this.tabPageAdd.Controls.Add(this.labelCIng);
            this.tabPageAdd.Controls.Add(this.labelCPrice);
            this.tabPageAdd.Controls.Add(this.labelCName);
            this.tabPageAdd.Location = new System.Drawing.Point(4, 29);
            this.tabPageAdd.Name = "tabPageAdd";
            this.tabPageAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdd.Size = new System.Drawing.Size(789, 414);
            this.tabPageAdd.TabIndex = 1;
            this.tabPageAdd.Text = "Add";
            this.tabPageAdd.UseVisualStyleBackColor = true;
            // 
            // labelCName
            // 
            this.labelCName.AutoSize = true;
            this.labelCName.Location = new System.Drawing.Point(31, 22);
            this.labelCName.Name = "labelCName";
            this.labelCName.Size = new System.Drawing.Size(49, 20);
            this.labelCName.TabIndex = 0;
            this.labelCName.Text = "Name";
            // 
            // labelCPrice
            // 
            this.labelCPrice.AutoSize = true;
            this.labelCPrice.Location = new System.Drawing.Point(201, 97);
            this.labelCPrice.Name = "labelCPrice";
            this.labelCPrice.Size = new System.Drawing.Size(41, 20);
            this.labelCPrice.TabIndex = 1;
            this.labelCPrice.Text = "Price";
            // 
            // labelCIng
            // 
            this.labelCIng.AutoSize = true;
            this.labelCIng.Location = new System.Drawing.Point(31, 86);
            this.labelCIng.Name = "labelCIng";
            this.labelCIng.Size = new System.Drawing.Size(83, 20);
            this.labelCIng.TabIndex = 2;
            this.labelCIng.Text = "Ingredients";
            // 
            // labelCReview
            // 
            this.labelCReview.AutoSize = true;
            this.labelCReview.Location = new System.Drawing.Point(31, 174);
            this.labelCReview.Name = "labelCReview";
            this.labelCReview.Size = new System.Drawing.Size(56, 20);
            this.labelCReview.TabIndex = 4;
            this.labelCReview.Text = "Review";
            // 
            // buttonCAdd
            // 
            this.buttonCAdd.Location = new System.Drawing.Point(363, 39);
            this.buttonCAdd.Name = "buttonCAdd";
            this.buttonCAdd.Size = new System.Drawing.Size(99, 45);
            this.buttonCAdd.TabIndex = 5;
            this.buttonCAdd.Text = "Add";
            this.buttonCAdd.UseVisualStyleBackColor = true;
            this.buttonCAdd.Click += new System.EventHandler(this.buttonCAdd_Click);
            // 
            // comboBoxPCategory
            // 
            this.comboBoxPCategory.FormattingEnabled = true;
            this.comboBoxPCategory.Location = new System.Drawing.Point(31, 358);
            this.comboBoxPCategory.Name = "comboBoxPCategory";
            this.comboBoxPCategory.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPCategory.TabIndex = 32;
            // 
            // comboBoxPCompany
            // 
            this.comboBoxPCompany.FormattingEnabled = true;
            this.comboBoxPCompany.Location = new System.Drawing.Point(31, 299);
            this.comboBoxPCompany.Name = "comboBoxPCompany";
            this.comboBoxPCompany.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPCompany.TabIndex = 31;
            // 
            // labelCCompany
            // 
            this.labelCCompany.AutoSize = true;
            this.labelCCompany.Location = new System.Drawing.Point(31, 276);
            this.labelCCompany.Name = "labelCCompany";
            this.labelCCompany.Size = new System.Drawing.Size(72, 20);
            this.labelCCompany.TabIndex = 30;
            this.labelCCompany.Text = "Company";
            // 
            // labelCCategory
            // 
            this.labelCCategory.AutoSize = true;
            this.labelCCategory.Location = new System.Drawing.Point(31, 330);
            this.labelCCategory.Name = "labelCCategory";
            this.labelCCategory.Size = new System.Drawing.Size(69, 20);
            this.labelCCategory.TabIndex = 29;
            this.labelCCategory.Text = "Category";
            // 
            // textBoxPReview
            // 
            this.textBoxPReview.Location = new System.Drawing.Point(31, 199);
            this.textBoxPReview.Multiline = true;
            this.textBoxPReview.Name = "textBoxPReview";
            this.textBoxPReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPReview.Size = new System.Drawing.Size(125, 71);
            this.textBoxPReview.TabIndex = 36;
            // 
            // textBoxPPrice
            // 
            this.textBoxPPrice.Location = new System.Drawing.Point(201, 120);
            this.textBoxPPrice.Name = "textBoxPPrice";
            this.textBoxPPrice.Size = new System.Drawing.Size(95, 27);
            this.textBoxPPrice.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 109);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(125, 62);
            this.textBox1.TabIndex = 34;
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(31, 39);
            this.textBoxPName.Multiline = true;
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPName.Size = new System.Drawing.Size(243, 45);
            this.textBoxPName.TabIndex = 33;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(363, 120);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 45);
            this.buttonClear.TabIndex = 37;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // PTrackerClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "PTrackerClient";
            this.Text = "PTrackerClient";
            this.tabControl1.ResumeLayout(false);
            this.tabPageFind.ResumeLayout(false);
            this.tabPageFind.PerformLayout();
            this.tabPageAdd.ResumeLayout(false);
            this.tabPageAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageFind;
        private Label labelRReview;
        private Label labelPIngredient;
        private TextBox textBoxRReview;
        private TextBox textBoxPIngredients;
        private Button buttonProducts;
        private TextBox textBoxSearch;
        private ListBox listBoxProducts;
        private TabPage tabPageAdd;
        private ComboBox comboBoxFProducts;
        private Label labelCReview;
        private Label labelCIng;
        private Label labelCPrice;
        private Label labelCName;
        private Button buttonCAdd;
        private ComboBox comboBoxPCategory;
        private ComboBox comboBoxPCompany;
        private Label labelCCompany;
        private Label labelCCategory;
        private TextBox textBoxPReview;
        private TextBox textBoxPPrice;
        private TextBox textBox1;
        private TextBox textBoxPName;
        private Button buttonClear;
    }
}