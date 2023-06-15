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
            this.labelRReview = new System.Windows.Forms.Label();
            this.labelPIngredient = new System.Windows.Forms.Label();
            this.textBoxRReview = new System.Windows.Forms.TextBox();
            this.textBoxPIngredients = new System.Windows.Forms.TextBox();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxFProducts = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPageFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFind);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            // labelRReview
            // 
            this.labelRReview.AutoSize = true;
            this.labelRReview.Location = new System.Drawing.Point(420, 273);
            this.labelRReview.Name = "labelRReview";
            this.labelRReview.Size = new System.Drawing.Size(50, 20);
            this.labelRReview.TabIndex = 6;
            this.labelRReview.Text = "Відгук";
            // 
            // labelPIngredient
            // 
            this.labelPIngredient.AutoSize = true;
            this.labelPIngredient.Location = new System.Drawing.Point(420, 128);
            this.labelPIngredient.Name = "labelPIngredient";
            this.labelPIngredient.Size = new System.Drawing.Size(49, 20);
            this.labelPIngredient.TabIndex = 5;
            this.labelPIngredient.Text = "Склад";
            // 
            // textBoxRReview
            // 
            this.textBoxRReview.Location = new System.Drawing.Point(494, 273);
            this.textBoxRReview.Multiline = true;
            this.textBoxRReview.Name = "textBoxRReview";
            this.textBoxRReview.Size = new System.Drawing.Size(259, 118);
            this.textBoxRReview.TabIndex = 4;
            // 
            // textBoxPIngredients
            // 
            this.textBoxPIngredients.Location = new System.Drawing.Point(494, 125);
            this.textBoxPIngredients.Multiline = true;
            this.textBoxPIngredients.Name = "textBoxPIngredients";
            this.textBoxPIngredients.Size = new System.Drawing.Size(259, 118);
            this.textBoxPIngredients.TabIndex = 3;
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
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 20;
            this.listBoxProducts.Location = new System.Drawing.Point(20, 122);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(378, 284);
            this.listBoxProducts.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(789, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxFProducts
            // 
            this.comboBoxFProducts.FormattingEnabled = true;
            this.comboBoxFProducts.Location = new System.Drawing.Point(26, 83);
            this.comboBoxFProducts.Name = "comboBoxFProducts";
            this.comboBoxFProducts.Size = new System.Drawing.Size(151, 28);
            this.comboBoxFProducts.TabIndex = 7;
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
        private TabPage tabPage2;
        private ComboBox comboBoxFProducts;
    }
}