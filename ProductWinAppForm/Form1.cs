using Product.Core.Entities;
using Product.Repositories;
using Products.Core.Contex;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace ProductWinAppForm
{
    public partial class Form1 : Form
    {
        private readonly ProductContex _context;
        public Form1()
        {
            InitializeComponent();
            _context = new ProductContex();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            loadDataViewProduct();
            loadDataViewCompany();
            loadDataViewCategory();
        }

        //products
        private void loadDataViewProduct()
        {

            var repositoryProducts = new Repository<Xavchik, Guid>(_context);
            var repositoryCompanies = new Repository<Company, Guid>(_context);
            var repositoryCategories = new Repository<Category, Guid>(_context);

            DataTable dataTableProduct = new DataTable();
            dataTableProduct.Columns.Add("id", typeof(Guid));
            dataTableProduct.Columns.Add("name", typeof(string));
            dataTableProduct.Columns.Add("ingredients", typeof(string));
            dataTableProduct.Columns.Add("price", typeof(float));
            dataTableProduct.Columns.Add("review", typeof(string));
            dataTableProduct.Columns.Add("verify", typeof(char));
            dataTableProduct.Columns.Add("companyId", typeof(string));
            dataTableProduct.Columns.Add("categoryId", typeof(string));

            Guid? companyID = null;
            Guid? categoryID = null;
            foreach (Xavchik product in repositoryProducts.GetAll())
            {
                foreach (var company in repositoryCompanies.GetAll())
                {
                    if (company.Id == product.company.Id)
                        companyID = company.Id;
                }
                foreach (var category in repositoryCategories.GetAll())
                {
                    if (category.Id == product.category.Id)
                        categoryID = category.Id;
                }
                dataTableProduct.Rows.Add(product.Id, product.name, product.ingredients, product.price, product.review, product.verify, companyID, categoryID);
            }

            dataGridViewProduct.DataSource = dataTableProduct;
            updateCompanyCB();
            updateCategoryCB();
        }
        private void loadDataViewCompany()
        {
            var repositoryCompanies = new Repository<Company , Guid>(new ProductContex());

            DataTable dataTableCompany = new DataTable();
            dataTableCompany.Columns.Add("id", typeof(Guid));
            dataTableCompany.Columns.Add("name", typeof(string));

            foreach (Company company in repositoryCompanies.GetAll())
            {
                dataTableCompany.Rows.Add(company.Id, company.name);
            }

            dataGridViewCompany.DataSource = dataTableCompany;
            ///updateProductCB();

        }
        private void loadDataViewCategory()
        {
            var repositoryCategory = new Repository<Category, Guid>(new ProductContex());

            DataTable dataTableCategory = new DataTable();
            dataTableCategory.Columns.Add("id", typeof(Guid));
            dataTableCategory.Columns.Add("name", typeof(string));

            foreach (Category category in repositoryCategory.GetAll())
            {
                dataTableCategory.Rows.Add(category.Id, category.name);
            }

            dataGridViewCategory.DataSource = dataTableCategory;
            ///updateProductCB();

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

        private void buttonPAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxPCompany.SelectedItem == null || comboBoxPCategory.SelectedItem == null ||
               string.IsNullOrEmpty(textBoxPName.Text) || string.IsNullOrEmpty(textBoxPIngredients.Text) || 
               string.IsNullOrEmpty(textBoxPPrice.Text) || string.IsNullOrEmpty(textBoxPReview.Text) ||
               string.IsNullOrEmpty(textBoxPVerify.Text))
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

            if (textBoxPVerify.Text == "T" || textBoxPVerify.Text == "F")
            {

                if (float.TryParse(textBoxPPrice.Text, out pricecheck))
                {
                    repositoryProducts.Create(new Xavchik
                    {
                        name = textBoxPName.Text,
                        ingredients = textBoxPIngredients.Text,
                        price = pricecheck,
                        review = textBoxPReview.Text,
                        verify = char.Parse(textBoxPVerify.Text),
                        companyId = CompanyIdSearch,
                        categoryId = CategoryIdSearch
                    });
                    loadDataViewProduct();
                    clearFieldProduct();
                    /* SetFalseEnable();*/
                }
                else
                {
                    MessageBox.Show("Invalid price format!");
                }
            }
            else
            {
                MessageBox.Show("Invalid verify format!");
            }                 
        }
        private void clearFieldProduct()
        {
            textBoxPName.Text= string.Empty;
            textBoxPIngredients.Text = string.Empty;
            textBoxPPrice.Text = string.Empty;  
            textBoxPReview.Text = string.Empty;
            textBoxPVerify.Text = string.Empty;
            comboBoxPCompany.SelectedIndex = -1;
            comboBoxPCompany.SelectedIndex = -1;
            dataGridViewProduct.ClearSelection();
        }

        //ДАНІ НЕ ЗАПОВНЮЮТЬСЯ В ОКСИ ПРИ ВИБОРІ З ДАТА ГРЕД ВЮЄВЕРА
        private void buttonPUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxPCompany.SelectedItem == null || comboBoxPCategory.SelectedItem == null ||
               string.IsNullOrEmpty(textBoxPName.Text) || string.IsNullOrEmpty(textBoxPIngredients.Text) ||
               string.IsNullOrEmpty(textBoxPPrice.Text) || string.IsNullOrEmpty(textBoxPReview.Text) ||
               string.IsNullOrEmpty(textBoxPVerify.Text))
            {
                MessageBox.Show("Заповніть поля", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridViewProduct.SelectedRows[0];

                string name = selectedRow.Cells["name"].Value.ToString();
                string ingredients = selectedRow.Cells["ingredients"].Value.ToString();
                float price = float.Parse(selectedRow.Cells["price"].Value.ToString());
                string review = selectedRow.Cells["review"].Value.ToString();
                char verify = char.Parse(selectedRow.Cells["verify"].Value.ToString());
                Guid companyId = Guid.Parse(selectedRow.Cells["companyId"].Value.ToString());
                Guid categoryId = Guid.Parse(selectedRow.Cells["categoryId"].Value.ToString());

                var repositoryProducts = new Repository<Xavchik, Guid>(_context);
                var repositoryCompanies = new Repository<Company, Guid>(_context);
                var repositoryCategories = new Repository<Category, Guid>(_context);

                DialogResult result = MessageBox.Show("Ви впевнені, що хочете оновити обраний елемент?", "Підтвердження оновлення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Update 
                if (result == DialogResult.Yes)
                {
                    string updateName = textBoxPName.Text;
                    string updateIngredients = textBoxPIngredients.Text;
                    float updatePrice = float.Parse(textBoxPPrice.Text);
                    string updateReview = textBoxPReview.Text;
                    char updateVerify = char.Parse(textBoxPVerify.Text);
                    string updateCompany = comboBoxPCompany.Text;
                    string updateCategory = comboBoxPCategory.Text;

                    var CompanyIdSearch = repositoryCompanies.GetAll().FirstOrDefault(company => company.name == updateCompany).Id;
                    var CategoryIdSearch = repositoryCategories.GetAll().FirstOrDefault(category => category.name == updateCategory).Id;

                    var productToUpdate = repositoryProducts.GetAll()
                        .FirstOrDefault(product =>
                            product.name == name &&
                            product.ingredients == ingredients &&
                            product.price == price &&
                            product.review == review &&
                            product.verify == verify &&
                            product.companyId == companyId &&
                            product.categoryId == categoryId
                        );

                    if (productToUpdate != null)
                    {
                        productToUpdate.name = updateName;
                        productToUpdate.ingredients = updateIngredients;
                        productToUpdate.price = updatePrice;
                        productToUpdate.review = updateReview;
                        productToUpdate.verify = updateVerify;
                        productToUpdate.companyId = CompanyIdSearch;
                        productToUpdate.categoryId = CategoryIdSearch;

                        _context.SaveChanges();
                        loadDataViewProduct();
                        clearFieldProduct();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonPDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити обраний елемент?", "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    DataGridViewRow selectedRow = dataGridViewProduct.SelectedRows[0];

                    string name = selectedRow.Cells["name"].Value.ToString();
                    string ingredients = selectedRow.Cells["ingredients"].Value.ToString();
                    float price = float.Parse(selectedRow.Cells["price"].Value.ToString());
                    string review = selectedRow.Cells["review"].Value.ToString();
                    char verify = char.Parse(selectedRow.Cells["verify"].Value.ToString());
                    Guid companyId = Guid.Parse(selectedRow.Cells["companyId"].Value.ToString());
                    Guid categoryId = Guid.Parse(selectedRow.Cells["categoryId"].Value.ToString());


                    /*string companyName = comboBoxPCompany.SelectedItem.ToString();
                    string categoryName = comboBoxPCategory.SelectedItem.ToString();*/

                    var repositoryProducts = new Repository<Xavchik, Guid>(_context);
                    var repositoryCompanies = new Repository<Company, Guid>(_context);
                    var repositoryCategories = new Repository<Category, Guid>(_context);

                   /* var CompanyIdSearch = repositoryCompanies.GetAll().FirstOrDefault(company => company.name == companyName).Id;
                    var CategoryIdSearch = repositoryCategories.GetAll().FirstOrDefault(category => category.name == categoryName).Id;

*/


                   // var productDelete = repositoryProducts.GetAll().First(trip => trip.month == month && trip.duration_sec == durationSec && trip.MemberId == memberHelp.Id && trip.BikeIntId == bikeId && trip.StartId == startHelp.TripId && trip.EndId == endHelp.TripId);
                    var productDelete = repositoryProducts.GetAll()
                       .FirstOrDefault(product =>
                           product.name == name &&
                           product.ingredients == ingredients &&
                           product.price == price &&
                           product.review == review &&
                       product.verify == verify &&
                           product.companyId == companyId &&
                           product.categoryId == categoryId
                       );
                    if (productDelete != null)
                    {
                        repositoryProducts.Delete(productDelete);

                    }


                    dataGridViewProduct.Rows.Remove(selectedRow);
                    loadDataViewProduct();
                    //SetFalseEnable();
                    clearFieldProduct();
                }
            }
        }
    }
}