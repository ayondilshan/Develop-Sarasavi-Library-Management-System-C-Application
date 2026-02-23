using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {

            string userName = txtLogin.Text;
            string password = txtPassword.Text;

            if (userName == "admin" && password == "12345")
            {
                this.Hide();
                frmLibrary frmLibrary = new frmLibrary();
                frmLibrary.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid user name or password");
            }
        }
    }
    }

