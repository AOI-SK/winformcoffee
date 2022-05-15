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
        int i;
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
            
            if(i <= 3)
            {
                if(txtName.Text != "AOI-SK" && txtPass.Text != "200212")
                {
                    MessageBox.Show("login failed", "error");
                    txtName.Clear();
                    txtPass.Clear();
                    txtName.Focus();
                }
                else if (txtName.Text == "AOI-SK" && txtPass.Text == "200212")
                {
                    MessageBox.Show("Logged in successfully!");
                    Forms.FormProducts formProducts = new Forms.FormProducts();
                    formProducts.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("login failed", "error");
                    txtName.Clear();
                    txtPass.Clear();
                    txtName.Focus();
                }
            }
            else if(i == 4)
            {
                MessageBox.Show("you try it 3 times already", "error");
                this.Close();
            }
            i++;         
        }
        
    }
}
