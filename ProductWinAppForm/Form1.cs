using Product.Core.Entities;
using Product.Repositories;
using Products.Core.Contex;
using System.Data;

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
                dataTableProduct.Rows.Add(product.Id, product.name, product.ingredients, product.price, product.review, companyID, categoryID);
            }

            dataGridViewProduct.DataSource = dataTableProduct;
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
    }
}