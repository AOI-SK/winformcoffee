using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCoffee.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            if (txtName.Text == "AOI-SK" && txtPass.Text == "200212")
            {
                MessageBox.Show("Logged in successfully!");
                Forms.FormProducts formProducts = new Forms.FormProducts();
                formProducts.Show();
                this.Hide();
            }
            else if (txtName.Text != "AOI-SK" || txtPass.Text != "200212")
            {
                for (i = 0; i < 3; i++)
                {
                    if (i <= 2)
                    {
                        MessageBox.Show("Login failure");
                        txtName.Clear();
                        txtPass.Clear();
                        txtName.Focus();
                        break;
                    }
                    else if (i == 3)
                    {
                        MessageBox.Show("Login failure");
                        this.Close();
                        break;
                    }
                }
            }
            
        }
        
    }
}
