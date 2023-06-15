using Products.Core.Contex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductWinAppForm
{
    public partial class PTrackerClient : Form
    {
        public PTrackerClient()
        {
            InitializeComponent();
            SetAutoCompleteTextbox(textBoxSearch);
            //FillComboBoxFProducts();
        }
        private void SetAutoCompleteTextbox(System.Windows.Forms.TextBox textBox)
        {
            using (var dbContext = new ProductContex())
            {
                var productNames = dbContext.Products.Select(p => p.name).ToList();

                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                autoCompleteCollection.AddRange(productNames.ToArray());

                textBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBox.AutoCompleteCustomSource = autoCompleteCollection;
                textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
        }
        /*private void FillComboBoxFProducts()
        {
            comboBoxFProducts.Items.Clear();

           *//* using (var dbContext = new ProductContex())
            {
                var categoryNames = dbContext.Categories.Select(c => c.name).Distinct().ToList();

                foreach (var categoryName in categoryNames)
                {
                    comboBoxFProducts.Items.Add(categoryName);
                }
            }*//*
        }*/

        public void updateProductsList()
        {
            string selectedCategory = comboBoxFProducts.SelectedItem?.ToString();

            using (var dbContext = new ProductContex())
            {
                if (!string.IsNullOrEmpty(selectedCategory))
                {
                    var products = dbContext.Products
                        .Where(p => p.category.name == selectedCategory)
                        .Select(p => new { ProductName = p.name, CompanyName = p.company.name })
                        .ToList();

                    listBoxProducts.Items.Clear();

                    foreach (var product in products)
                    {
                        string listItem = product.ProductName + " : " + product.CompanyName;
                        listBoxProducts.Items.Add(listItem);
                    }
                }
                else
                {
                    string searchValue = textBoxSearch.Text;
                    var products = dbContext.Products
                        .Where(p => p.name.StartsWith(searchValue))
                        .Select(p => new { ProductName = p.name, CompanyName = p.company.name })
                        .ToList();

                    listBoxProducts.Items.Clear();

                    foreach (var product in products)
                    {
                        string listItem = product.ProductName + " : " + product.CompanyName;
                        listBoxProducts.Items.Add(listItem);
                    }
                }
            }

        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            updateProductsList();
        }
    }
}
