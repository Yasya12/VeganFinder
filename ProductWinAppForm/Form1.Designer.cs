namespace ProductWinAppForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlProd = new System.Windows.Forms.TabControl();
            this.tabPageProduct = new System.Windows.Forms.TabPage();
            this.buttonPSearch = new System.Windows.Forms.Button();
            this.buttonPClear = new System.Windows.Forms.Button();
            this.buttonPUpdate = new System.Windows.Forms.Button();
            this.buttonPDelete = new System.Windows.Forms.Button();
            this.buttonPAdd = new System.Windows.Forms.Button();
            this.comboBoxPCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxPCompany = new System.Windows.Forms.ComboBox();
            this.textBoxPReview = new System.Windows.Forms.TextBox();
            this.textBoxPPrice = new System.Windows.Forms.TextBox();
            this.textBoxPIngredients = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPVerify = new System.Windows.Forms.TextBox();
            this.textBoxPName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.buttonCSearch = new System.Windows.Forms.Button();
            this.buttonCClear = new System.Windows.Forms.Button();
            this.buttonCUpdate = new System.Windows.Forms.Button();
            this.buttonCDelete = new System.Windows.Forms.Button();
            this.buttonCAdd = new System.Windows.Forms.Button();
            this.textBoxCName = new System.Windows.Forms.TextBox();
            this.labelCName = new System.Windows.Forms.Label();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
            this.buttonCaSearch = new System.Windows.Forms.Button();
            this.buttonCaClear = new System.Windows.Forms.Button();
            this.buttonCaUpdate = new System.Windows.Forms.Button();
            this.buttonCaDelete = new System.Windows.Forms.Button();
            this.buttonCaAdd = new System.Windows.Forms.Button();
            this.textBoxCaName = new System.Windows.Forms.TextBox();
            this.labelCaName = new System.Windows.Forms.Label();
            this.dataGridViewCategory = new System.Windows.Forms.DataGridView();
            this.tabControlProd.SuspendLayout();
            this.tabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.tabPageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).BeginInit();
            this.tabPageCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProd
            // 
            this.tabControlProd.Controls.Add(this.tabPageProduct);
            this.tabControlProd.Controls.Add(this.tabPageCompany);
            this.tabControlProd.Controls.Add(this.tabPageCategory);
            this.tabControlProd.Location = new System.Drawing.Point(12, 12);
            this.tabControlProd.Name = "tabControlProd";
            this.tabControlProd.SelectedIndex = 0;
            this.tabControlProd.Size = new System.Drawing.Size(776, 426);
            this.tabControlProd.TabIndex = 1;
            // 
            // tabPageProduct
            // 
            this.tabPageProduct.Controls.Add(this.buttonPSearch);
            this.tabPageProduct.Controls.Add(this.buttonPClear);
            this.tabPageProduct.Controls.Add(this.buttonPUpdate);
            this.tabPageProduct.Controls.Add(this.buttonPDelete);
            this.tabPageProduct.Controls.Add(this.buttonPAdd);
            this.tabPageProduct.Controls.Add(this.comboBoxPCategory);
            this.tabPageProduct.Controls.Add(this.comboBoxPCompany);
            this.tabPageProduct.Controls.Add(this.textBoxPReview);
            this.tabPageProduct.Controls.Add(this.textBoxPPrice);
            this.tabPageProduct.Controls.Add(this.textBoxPIngredients);
            this.tabPageProduct.Controls.Add(this.label3);
            this.tabPageProduct.Controls.Add(this.label4);
            this.tabPageProduct.Controls.Add(this.label5);
            this.tabPageProduct.Controls.Add(this.label6);
            this.tabPageProduct.Controls.Add(this.label7);
            this.tabPageProduct.Controls.Add(this.textBoxPVerify);
            this.tabPageProduct.Controls.Add(this.textBoxPName);
            this.tabPageProduct.Controls.Add(this.label1);
            this.tabPageProduct.Controls.Add(this.label2);
            this.tabPageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 29);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(768, 393);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
            // 
            // buttonPSearch
            // 
            this.buttonPSearch.Location = new System.Drawing.Point(118, 335);
            this.buttonPSearch.Name = "buttonPSearch";
            this.buttonPSearch.Size = new System.Drawing.Size(90, 45);
            this.buttonPSearch.TabIndex = 33;
            this.buttonPSearch.Text = "Search";
            this.buttonPSearch.UseVisualStyleBackColor = true;
            this.buttonPSearch.Click += new System.EventHandler(this.buttonPSearch_Click);
            // 
            // buttonPClear
            // 
            this.buttonPClear.Location = new System.Drawing.Point(249, 336);
            this.buttonPClear.Name = "buttonPClear";
            this.buttonPClear.Size = new System.Drawing.Size(90, 45);
            this.buttonPClear.TabIndex = 32;
            this.buttonPClear.Text = "Clear";
            this.buttonPClear.UseVisualStyleBackColor = true;
            this.buttonPClear.Click += new System.EventHandler(this.buttonPClear_Click);
            // 
            // buttonPUpdate
            // 
            this.buttonPUpdate.Location = new System.Drawing.Point(307, 285);
            this.buttonPUpdate.Name = "buttonPUpdate";
            this.buttonPUpdate.Size = new System.Drawing.Size(90, 45);
            this.buttonPUpdate.TabIndex = 31;
            this.buttonPUpdate.Text = "Update";
            this.buttonPUpdate.UseVisualStyleBackColor = true;
            this.buttonPUpdate.Click += new System.EventHandler(this.buttonPUpdate_Click);
            // 
            // buttonPDelete
            // 
            this.buttonPDelete.Location = new System.Drawing.Point(176, 284);
            this.buttonPDelete.Name = "buttonPDelete";
            this.buttonPDelete.Size = new System.Drawing.Size(90, 45);
            this.buttonPDelete.TabIndex = 30;
            this.buttonPDelete.Text = "Delete";
            this.buttonPDelete.UseVisualStyleBackColor = true;
            this.buttonPDelete.Click += new System.EventHandler(this.buttonPDelete_Click);
            // 
            // buttonPAdd
            // 
            this.buttonPAdd.Location = new System.Drawing.Point(44, 284);
            this.buttonPAdd.Name = "buttonPAdd";
            this.buttonPAdd.Size = new System.Drawing.Size(90, 45);
            this.buttonPAdd.TabIndex = 29;
            this.buttonPAdd.Text = "Add";
            this.buttonPAdd.UseVisualStyleBackColor = true;
            this.buttonPAdd.Click += new System.EventHandler(this.buttonPAdd_Click);
            // 
            // comboBoxPCategory
            // 
            this.comboBoxPCategory.FormattingEnabled = true;
            this.comboBoxPCategory.Location = new System.Drawing.Point(506, 353);
            this.comboBoxPCategory.Name = "comboBoxPCategory";
            this.comboBoxPCategory.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPCategory.TabIndex = 28;
            // 
            // comboBoxPCompany
            // 
            this.comboBoxPCompany.FormattingEnabled = true;
            this.comboBoxPCompany.Location = new System.Drawing.Point(506, 285);
            this.comboBoxPCompany.Name = "comboBoxPCompany";
            this.comboBoxPCompany.Size = new System.Drawing.Size(151, 28);
            this.comboBoxPCompany.TabIndex = 27;
            // 
            // textBoxPReview
            // 
            this.textBoxPReview.Location = new System.Drawing.Point(506, 188);
            this.textBoxPReview.Multiline = true;
            this.textBoxPReview.Name = "textBoxPReview";
            this.textBoxPReview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPReview.Size = new System.Drawing.Size(125, 71);
            this.textBoxPReview.TabIndex = 26;
            // 
            // textBoxPPrice
            // 
            this.textBoxPPrice.Location = new System.Drawing.Point(654, 232);
            this.textBoxPPrice.Name = "textBoxPPrice";
            this.textBoxPPrice.Size = new System.Drawing.Size(95, 27);
            this.textBoxPPrice.TabIndex = 25;
            // 
            // textBoxPIngredients
            // 
            this.textBoxPIngredients.Location = new System.Drawing.Point(506, 100);
            this.textBoxPIngredients.Multiline = true;
            this.textBoxPIngredients.Name = "textBoxPIngredients";
            this.textBoxPIngredients.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPIngredients.Size = new System.Drawing.Size(125, 62);
            this.textBoxPIngredients.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(506, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Ingredients";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Review";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(506, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Company";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(506, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Category";
            // 
            // textBoxPVerify
            // 
            this.textBoxPVerify.Location = new System.Drawing.Point(654, 135);
            this.textBoxPVerify.Name = "textBoxPVerify";
            this.textBoxPVerify.Size = new System.Drawing.Size(51, 27);
            this.textBoxPVerify.TabIndex = 18;
            // 
            // textBoxPName
            // 
            this.textBoxPName.Location = new System.Drawing.Point(506, 29);
            this.textBoxPName.Multiline = true;
            this.textBoxPName.Name = "textBoxPName";
            this.textBoxPName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxPName.Size = new System.Drawing.Size(243, 45);
            this.textBoxPName.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Verify";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 51;
            this.dataGridViewProduct.RowTemplate.Height = 29;
            this.dataGridViewProduct.Size = new System.Drawing.Size(485, 253);
            this.dataGridViewProduct.TabIndex = 1;
            this.dataGridViewProduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewProduct_RowHeaderMouseClick);
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.buttonCSearch);
            this.tabPageCompany.Controls.Add(this.buttonCClear);
            this.tabPageCompany.Controls.Add(this.buttonCUpdate);
            this.tabPageCompany.Controls.Add(this.buttonCDelete);
            this.tabPageCompany.Controls.Add(this.buttonCAdd);
            this.tabPageCompany.Controls.Add(this.textBoxCName);
            this.tabPageCompany.Controls.Add(this.labelCName);
            this.tabPageCompany.Controls.Add(this.dataGridViewCompany);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(768, 393);
            this.tabPageCompany.TabIndex = 1;
            this.tabPageCompany.Text = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
            // 
            // buttonCSearch
            // 
            this.buttonCSearch.Location = new System.Drawing.Point(106, 338);
            this.buttonCSearch.Name = "buttonCSearch";
            this.buttonCSearch.Size = new System.Drawing.Size(90, 45);
            this.buttonCSearch.TabIndex = 40;
            this.buttonCSearch.Text = "Search";
            this.buttonCSearch.UseVisualStyleBackColor = true;
            this.buttonCSearch.Click += new System.EventHandler(this.buttonCSearch_Click);
            // 
            // buttonCClear
            // 
            this.buttonCClear.Location = new System.Drawing.Point(237, 339);
            this.buttonCClear.Name = "buttonCClear";
            this.buttonCClear.Size = new System.Drawing.Size(90, 45);
            this.buttonCClear.TabIndex = 39;
            this.buttonCClear.Text = "Clear";
            this.buttonCClear.UseVisualStyleBackColor = true;
            this.buttonCClear.Click += new System.EventHandler(this.buttonCClear_Click);
            // 
            // buttonCUpdate
            // 
            this.buttonCUpdate.Location = new System.Drawing.Point(295, 288);
            this.buttonCUpdate.Name = "buttonCUpdate";
            this.buttonCUpdate.Size = new System.Drawing.Size(90, 45);
            this.buttonCUpdate.TabIndex = 38;
            this.buttonCUpdate.Text = "Update";
            this.buttonCUpdate.UseVisualStyleBackColor = true;
            this.buttonCUpdate.Click += new System.EventHandler(this.buttonCUpdate_Click);
            // 
            // buttonCDelete
            // 
            this.buttonCDelete.Location = new System.Drawing.Point(164, 287);
            this.buttonCDelete.Name = "buttonCDelete";
            this.buttonCDelete.Size = new System.Drawing.Size(90, 45);
            this.buttonCDelete.TabIndex = 37;
            this.buttonCDelete.Text = "Delete";
            this.buttonCDelete.UseVisualStyleBackColor = true;
            this.buttonCDelete.Click += new System.EventHandler(this.buttonCDelete_Click);
            // 
            // buttonCAdd
            // 
            this.buttonCAdd.Location = new System.Drawing.Point(32, 287);
            this.buttonCAdd.Name = "buttonCAdd";
            this.buttonCAdd.Size = new System.Drawing.Size(90, 45);
            this.buttonCAdd.TabIndex = 36;
            this.buttonCAdd.Text = "Add";
            this.buttonCAdd.UseVisualStyleBackColor = true;
            this.buttonCAdd.Click += new System.EventHandler(this.buttonCAdd_Click);
            // 
            // textBoxCName
            // 
            this.textBoxCName.Location = new System.Drawing.Point(494, 32);
            this.textBoxCName.Name = "textBoxCName";
            this.textBoxCName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCName.Size = new System.Drawing.Size(243, 27);
            this.textBoxCName.TabIndex = 35;
            // 
            // labelCName
            // 
            this.labelCName.AutoSize = true;
            this.labelCName.Location = new System.Drawing.Point(494, 9);
            this.labelCName.Name = "labelCName";
            this.labelCName.Size = new System.Drawing.Size(49, 20);
            this.labelCName.TabIndex = 34;
            this.labelCName.Text = "Name";
            // 
            // dataGridViewCompany
            // 
            this.dataGridViewCompany.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompany.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCompany.Name = "dataGridViewCompany";
            this.dataGridViewCompany.RowHeadersWidth = 51;
            this.dataGridViewCompany.RowTemplate.Height = 29;
            this.dataGridViewCompany.Size = new System.Drawing.Size(485, 253);
            this.dataGridViewCompany.TabIndex = 2;
            this.dataGridViewCompany.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCompany_RowHeaderMouseClick);
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.buttonCaSearch);
            this.tabPageCategory.Controls.Add(this.buttonCaClear);
            this.tabPageCategory.Controls.Add(this.buttonCaUpdate);
            this.tabPageCategory.Controls.Add(this.buttonCaDelete);
            this.tabPageCategory.Controls.Add(this.buttonCaAdd);
            this.tabPageCategory.Controls.Add(this.textBoxCaName);
            this.tabPageCategory.Controls.Add(this.labelCaName);
            this.tabPageCategory.Controls.Add(this.dataGridViewCategory);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(768, 393);
            this.tabPageCategory.TabIndex = 2;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
            // 
            // buttonCaSearch
            // 
            this.buttonCaSearch.Location = new System.Drawing.Point(106, 338);
            this.buttonCaSearch.Name = "buttonCaSearch";
            this.buttonCaSearch.Size = new System.Drawing.Size(90, 45);
            this.buttonCaSearch.TabIndex = 47;
            this.buttonCaSearch.Text = "Search";
            this.buttonCaSearch.UseVisualStyleBackColor = true;
            this.buttonCaSearch.Click += new System.EventHandler(this.buttonCaSearch_Click);
            // 
            // buttonCaClear
            // 
            this.buttonCaClear.Location = new System.Drawing.Point(237, 339);
            this.buttonCaClear.Name = "buttonCaClear";
            this.buttonCaClear.Size = new System.Drawing.Size(90, 45);
            this.buttonCaClear.TabIndex = 46;
            this.buttonCaClear.Text = "Clear";
            this.buttonCaClear.UseVisualStyleBackColor = true;
            this.buttonCaClear.Click += new System.EventHandler(this.buttonCaClear_Click);
            // 
            // buttonCaUpdate
            // 
            this.buttonCaUpdate.Location = new System.Drawing.Point(295, 288);
            this.buttonCaUpdate.Name = "buttonCaUpdate";
            this.buttonCaUpdate.Size = new System.Drawing.Size(90, 45);
            this.buttonCaUpdate.TabIndex = 45;
            this.buttonCaUpdate.Text = "Update";
            this.buttonCaUpdate.UseVisualStyleBackColor = true;
            this.buttonCaUpdate.Click += new System.EventHandler(this.buttonCaUpdate_Click);
            // 
            // buttonCaDelete
            // 
            this.buttonCaDelete.Location = new System.Drawing.Point(164, 287);
            this.buttonCaDelete.Name = "buttonCaDelete";
            this.buttonCaDelete.Size = new System.Drawing.Size(90, 45);
            this.buttonCaDelete.TabIndex = 44;
            this.buttonCaDelete.Text = "Delete";
            this.buttonCaDelete.UseVisualStyleBackColor = true;
            this.buttonCaDelete.Click += new System.EventHandler(this.buttonCaDelete_Click);
            // 
            // buttonCaAdd
            // 
            this.buttonCaAdd.Location = new System.Drawing.Point(32, 287);
            this.buttonCaAdd.Name = "buttonCaAdd";
            this.buttonCaAdd.Size = new System.Drawing.Size(90, 45);
            this.buttonCaAdd.TabIndex = 43;
            this.buttonCaAdd.Text = "Add";
            this.buttonCaAdd.UseVisualStyleBackColor = true;
            this.buttonCaAdd.Click += new System.EventHandler(this.buttonCaAdd_Click);
            // 
            // textBoxCaName
            // 
            this.textBoxCaName.Location = new System.Drawing.Point(494, 32);
            this.textBoxCaName.Name = "textBoxCaName";
            this.textBoxCaName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCaName.Size = new System.Drawing.Size(243, 27);
            this.textBoxCaName.TabIndex = 42;
            // 
            // labelCaName
            // 
            this.labelCaName.AutoSize = true;
            this.labelCaName.Location = new System.Drawing.Point(494, 9);
            this.labelCaName.Name = "labelCaName";
            this.labelCaName.Size = new System.Drawing.Size(49, 20);
            this.labelCaName.TabIndex = 41;
            this.labelCaName.Text = "Name";
            // 
            // dataGridViewCategory
            // 
            this.dataGridViewCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategory.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewCategory.Name = "dataGridViewCategory";
            this.dataGridViewCategory.RowHeadersWidth = 51;
            this.dataGridViewCategory.RowTemplate.Height = 29;
            this.dataGridViewCategory.Size = new System.Drawing.Size(485, 253);
            this.dataGridViewCategory.TabIndex = 2;
            this.dataGridViewCategory.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewCategory_RowHeaderMouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlProd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlProd.ResumeLayout(false);
            this.tabPageProduct.ResumeLayout(false);
            this.tabPageProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageCompany.ResumeLayout(false);
            this.tabPageCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
            this.tabPageCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlProd;
        private TabPage tabPageProduct;
        private DataGridView dataGridViewProduct;
        private TabPage tabPageCompany;
        private DataGridView dataGridViewCompany;
        private TabPage tabPageCategory;
        private DataGridView dataGridViewCategory;
        private Button buttonPSearch;
        private Button buttonPClear;
        private Button buttonPUpdate;
        private Button buttonPDelete;
        private Button buttonPAdd;
        private ComboBox comboBoxPCategory;
        private ComboBox comboBoxPCompany;
        private TextBox textBoxPReview;
        private TextBox textBoxPPrice;
        private TextBox textBoxPIngredients;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxPVerify;
        private TextBox textBoxPName;
        private Label label1;
        private Label label2;
        private Button buttonCSearch;
        private Button buttonCClear;
        private Button buttonCUpdate;
        private Button buttonCDelete;
        private Button buttonCAdd;
        private TextBox textBoxCName;
        private Label labelCName;
        private Button buttonCaSearch;
        private Button buttonCaClear;
        private Button buttonCaUpdate;
        private Button buttonCaDelete;
        private Button buttonCaAdd;
        private TextBox textBoxCaName;
        private Label labelCaName;
    }
}