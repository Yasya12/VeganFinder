using Product.Repositories;
using Products.Core.Contex;
using ProductWinAppForm;

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
            if (!string.IsNullOrEmpty(textBoxLPassword.Text) && !string.IsNullOrEmpty(textBoxLUserName.Text))
            {
                string username = textBoxLUserName.Text;
                string password = textBoxLPassword.Text;

                var user = _context.Users.FirstOrDefault(u => u.name == username && u.password == password);

                if (user != null)
                {
                    char powerValue = user.power;
                    this.Hide();
                    //powerValue = powerValue.Trim();

                    if (powerValue == 'T')
                    {
                        PTrackerAdmin tracker = new PTrackerAdmin();
                        tracker.ShowDialog();
                    }
                    else if (powerValue == 'F')
                    {
                        PTrackerClient tracker = new PTrackerClient();
                        tracker.ShowDialog();
                    }
                }
                else
                {
                    Clear();
                    MessageBox.Show("No Account available with this username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void buttonLRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }
        private void Clear()
        {
            textBoxLUserName.Text = string.Empty;
            textBoxLPassword.Text = string.Empty;
        }
    }
}