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
    public partial class frmViewReturnBooks : Form
    {
        public frmViewReturnBooks()
        {
            InitializeComponent();

            string connectionString = Connection.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
        SELECT TOP (1000)
            copy_id AS [Copy ID],
            book_id AS [Book ID],
            is_reference AS [Reference?],
            status AS [Status]
        FROM Copies
        ORDER BY copy_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvCopies.DataSource = table;
            }
        }

        private void dgvLoans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        

               
            
        }

        private void frmViewReturnBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmLibrary frmLibrary = new frmLibrary();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


          
        {
            string connectionString = Connection.connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"
        SELECT TOP (1000)
            copy_id AS [Copy ID],
            book_id AS [Book ID],
            is_reference AS [Reference?],
            status AS [Status]
        FROM Copies
        ORDER BY copy_id";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvCopies.DataSource = table;
            }
        }
    }
    }
    }
    
