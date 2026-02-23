using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.frmUserO;

namespace WindowsFormsApp1
{
    public partial class frmViewUsers : Form
    {
        public frmViewUsers()
        {
            InitializeComponent();
            string connectionString = Connection.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT * FROM Users";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            dataGridViewUsers.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnaddBook_Click(object sender, EventArgs e)
        {
            frmLibrary home = new frmLibrary();
            home.Show();
            this.Hide();
        }

        private void frmViewUsers_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLibrary frmLibrary = new frmLibrary();
                this.Hide();
        }
    }
}

