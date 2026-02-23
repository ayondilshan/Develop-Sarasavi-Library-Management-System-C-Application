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
    public partial class frmViewLoanBooks : Form
    {
        public frmViewLoanBooks()
        {
            InitializeComponent();
            string connectionString = Connection.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"
SELECT 
    u.user_id AS [User ID],
    l.copy_id AS [Copy ID],
    l.loan_date AS [Loan Date],
    l.return_date AS [Return Date]
FROM Loans l
JOIN Users u ON l.user_id = u.user_id
JOIN Copies c ON l.copy_id = c.copy_id
JOIN Books b ON c.book_id = b.book_id
ORDER BY l.loan_date DESC";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvLoans.DataSource = table;

        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmViewLoanBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmLibrary frmLibrary = new frmLibrary();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
