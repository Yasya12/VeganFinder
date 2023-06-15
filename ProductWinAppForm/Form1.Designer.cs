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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.tabPageCompany = new System.Windows.Forms.TabPage();
            this.dataGridViewCompany = new System.Windows.Forms.DataGridView();
            this.tabPageCategory = new System.Windows.Forms.TabPage();
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
            this.tabPageProduct.Controls.Add(this.dataGridViewProduct);
            this.tabPageProduct.Location = new System.Drawing.Point(4, 29);
            this.tabPageProduct.Name = "tabPageProduct";
            this.tabPageProduct.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProduct.Size = new System.Drawing.Size(768, 393);
            this.tabPageProduct.TabIndex = 0;
            this.tabPageProduct.Text = "Product";
            this.tabPageProduct.UseVisualStyleBackColor = true;
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
            // 
            // tabPageCompany
            // 
            this.tabPageCompany.Controls.Add(this.dataGridViewCompany);
            this.tabPageCompany.Location = new System.Drawing.Point(4, 29);
            this.tabPageCompany.Name = "tabPageCompany";
            this.tabPageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompany.Size = new System.Drawing.Size(768, 393);
            this.tabPageCompany.TabIndex = 1;
            this.tabPageCompany.Text = "Company";
            this.tabPageCompany.UseVisualStyleBackColor = true;
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
            // 
            // tabPageCategory
            // 
            this.tabPageCategory.Controls.Add(this.dataGridViewCategory);
            this.tabPageCategory.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategory.Name = "tabPageCategory";
            this.tabPageCategory.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategory.Size = new System.Drawing.Size(768, 393);
            this.tabPageCategory.TabIndex = 2;
            this.tabPageCategory.Text = "Category";
            this.tabPageCategory.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.tabPageCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompany)).EndInit();
            this.tabPageCategory.ResumeLayout(false);
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
    }
}