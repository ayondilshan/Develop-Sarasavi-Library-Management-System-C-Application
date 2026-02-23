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
    public partial class frmViewBooks : Form
    {
        public frmViewBooks()
        {
            InitializeComponent();
           
      
            string connectionString = Connection.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = @"SELECT 
                        b.book_id AS [Book ID],
                        b.title AS [Title],
                        b.author AS [Author],
                        b.isbn AS [ISBN],
                        b.classification AS [Classification],
                        b.total AS [Total Copies],
                        b.reference AS [Reference Copies],
                        COUNT(c.copy_id) AS [Physical Copies]
                    FROM Books b
                    LEFT JOIN Copies c ON b.book_id = c.book_id
                    GROUP BY b.book_id, b.title, b.author, b.isbn, b.classification, b.total, b.reference";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvBooks.DataSource = table;
        }
        

        private void frmViewBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
