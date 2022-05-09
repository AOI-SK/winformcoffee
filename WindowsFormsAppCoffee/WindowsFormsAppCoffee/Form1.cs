using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsAppCoffee.Forms;

namespace WindowsFormsAppCoffee
{
    public partial class FormMainMenu : Form
    {
       

        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Forms.FormLogin formLogin = new Forms.FormLogin();
            formLogin.Show();
        }
    }

    internal class txtPass
    {
        internal static string Text;
    }

    internal class txtName
    {
        internal static string Text;
    }
}
