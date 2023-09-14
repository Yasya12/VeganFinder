using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Product.Core.Entities;
using Product.Repositories;
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

        private readonly ProductContex _context;
        public PTrackerClient()
        {
            InitializeComponent();
            SetAutoCompleteTextbox(textBoxSearch);
            //FillComboBoxFProducts();
            _context = new ProductContex();
            updateCompanyCB();
            updateCategoryCB();
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
        /* private void FillComboBoxFProducts()
         {
             comboBoxFProducts.Items.Clear();

             using (var dbContext = new ProductContex())
             {
                 var categoryNames = dbContext.Categories.Select(c => c.name).Distinct().ToList();

                 foreach (var categoryName in categoryNames)
                 {
                     comboBoxFProducts.Items.Add(categoryName);
                 }
             }
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
            listBoxProducts.Visible = true;
            listBoxProducts.Items.Clear();
            updateProductsList();
        }

        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxPIngredients.Visible = listBoxProducts.SelectedIndex != -1;
            labelPIngredient.Visible = listBoxProducts.SelectedIndex != -1;
            textBoxRReview.Visible = listBoxProducts.SelectedIndex != -1;
            labelRReview.Visible = listBoxProducts.SelectedIndex != -1;

            ShowProductComposition();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxProducts.Visible = false;
            textBoxPIngredients.Visible = false;
            labelPIngredient.Visible = false;
            textBoxRReview.Visible = false;
            labelRReview.Visible = false;
        }
        public void ShowProductComposition()
        {
            if (listBoxProducts.SelectedItem != null)
            {
                string selectedProduct = listBoxProducts.SelectedItem.ToString();
                string productName = selectedProduct.Split(':')[0].Trim();

                using (var dbContext = new ProductContex())
                {
                    var repository = new Repository<Xavchik, Guid>(new ProductContex());

                    var CompanyIngredientsSearch = repository.GetAll().FirstOrDefault(product => product.name == productName).ingredients;
                    var CompanyReviewSearch = repository.GetAll().FirstOrDefault(product => product.name == productName).review;

                    if (CompanyIngredientsSearch != null)
                    {
                        textBoxPIngredients.Text = CompanyIngredientsSearch;
                        textBoxRReview.Text = CompanyReviewSearch;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        private void buttonCAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPCompany.SelectedItem == null || comboBoxPCategory.SelectedItem == null ||
              string.IsNullOrEmpty(textBoxPName.Text) || string.IsNullOrEmpty(textBoxPIngredients.Text) ||
              string.IsNullOrEmpty(textBoxPPrice.Text) || string.IsNullOrEmpty(textBoxPReview.Text))
            {
                MessageBox.Show("Заповніть поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string companyName = comboBoxPCompany.SelectedItem.ToString();
            string categoryName = comboBoxPCategory.SelectedItem.ToString();
            float pricecheck;

            var repositoryProducts = new Repository<Xavchik, Guid>(_context);
            var repositoryCompanies = new Repository<Company, Guid>(_context);
            var repositoryCategories = new Repository<Category, Guid>(_context);

            var CompanyIdSearch = repositoryCompanies.GetAll().FirstOrDefault(company => company.name == companyName).Id;
            var CategoryIdSearch = repositoryCategories.GetAll().FirstOrDefault(category => category.name == categoryName).Id;

            
                if (float.TryParse(textBoxPPrice.Text, out pricecheck))
                {
                    repositoryProducts.Create(new Xavchik
                    {
                        name = textBoxPName.Text,
                        ingredients = textBoxPIngredients.Text,
                        price = pricecheck,
                        review = textBoxPReview.Text,
                        verify = 'F',
                        companyId = CompanyIdSearch,
                        categoryId = CategoryIdSearch
                    });
                    clearFieldProduct();
                    /* SetFalseEnable();*/
                }
                else
                {
                    MessageBox.Show("Invalid price format!");
                }
        }

        private void updateCompanyCB()
        {
            var repository = new Repository<Company, Guid>(new ProductContex());
            comboBoxPCompany.Items.Clear();

            foreach (var company in repository.GetAll())
            {
                comboBoxPCompany.Items.Add($"{company.name}");
            }
        }
        private void updateCategoryCB()
        {
            var repository = new Repository<Category, Guid>(new ProductContex());
            comboBoxPCategory.Items.Clear();

            foreach (var category in repository.GetAll())
            {
                comboBoxPCategory.Items.Add($"{category.name}");
            }
        }
        private void clearFieldProduct()
        {
            textBoxPName.Text = string.Empty;
            textBoxIngre.Text = string.Empty;
            textBoxPPrice.Text = string.Empty;
            textBoxPReview.Text = string.Empty;
            comboBoxPCompany.SelectedIndex = -1;
            comboBoxPCategory.SelectedIndex = -1;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearFieldProduct();
        }
    }
}
