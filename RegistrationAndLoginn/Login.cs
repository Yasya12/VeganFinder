using Product.Repositories;
using Products.Core.Contex;

namespace RegistrationAndLoginn
{
    public partial class Login : Form
    {
        private readonly ProductContex _context;
        public Login()
        {
            InitializeComponent();
            _context = new ProductContex();
        }

        private void buttonLLogin_Click(object sender, EventArgs e)
        {

        }
    }
}