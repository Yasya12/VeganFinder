using Microsoft.EntityFrameworkCore;
using Product.Core.Entities;
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

namespace RegistrationAndLoginn
{
    public partial class Registration : Form
    {
        private ProductContex _context;
        public Registration()
        {
            InitializeComponent();
            _context = new ProductContex();
        }

        private void buttonRRegister_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRPassword.Text) && !string.IsNullOrEmpty(textBoxRCPassword.Text) && !string.IsNullOrEmpty(textBoxRUserName.Text))
            {
                if (textBoxRPassword.Text == textBoxRCPassword.Text)
                {
                    var existingUser = _context.Users.FirstOrDefault(u => u.name == textBoxRUserName.Text);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Username Already exists. Please try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Guid id = Guid.NewGuid();
                        User newUser = new User
                        {
                            Id = id,
                            name = textBoxRUserName.Text,
                            password = textBoxRPassword.Text,
                            power = 'F'
                        };
                        _context.Users.Add(newUser);
                        _context.SaveChanges();
                        ClearAll();
                        MessageBox.Show("Your Account is created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginShow();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the same password in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginShow()
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }
        private void ClearAll()
        {
            textBoxRUserName.Text = string.Empty;
            textBoxRPassword.Text = string.Empty;
            textBoxRCPassword.Text = string.Empty;
        }
    }
}
 


