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

namespace WindowsFormsApp1
{
    public partial class frmBookInquiry : Form
    {
        private string connectionString = @"Data Source=DESKTOP-VO1KQCT\SQLEXPRESS;
          Initial Catalog=Sarasavi_Library_DB;
          Integrated Security=True;
          TrustServerCertificate=True;";
        public frmBookInquiry()

        {
            InitializeComponent();
        }

        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Please enter a search term.");
                return;
            }

            string sql = @"
                SELECT book_id, title, author, isbn, classification, total, reference
                FROM Books
                WHERE book_id LIKE @search
                   OR title LIKE @search
                   OR author LIKE @search";

            using (SqlConnection conn = new SqlConnection(connectionString)) 
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                try
                {
                    conn.Open();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dataGridBooks.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("No books found matching your search.");
                        dataGridBooks.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void frmBookInquiry_Load(object sender, EventArgs e)
        {

        }
        

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            
            txtSearch.Text = "";

           
            dataGridBooks.DataSource = null;

            
            txtSearch.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmViewReservations f = new frmViewReservations();
            f.Show();
        }
    }
}





