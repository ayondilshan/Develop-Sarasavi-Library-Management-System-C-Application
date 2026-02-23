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
    public partial class frmViewReservations : Form
    {
        public frmViewReservations()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection con = new SqlConnection(Connection.connectionString))
                {
                    con.Open();

                    string query = @"SELECT 
                                r.reservation_id,
                                u.name AS UserName,
                                b.title AS BookTitle,
                                r.reservation_date,
                                r.status
                             FROM Reservations r
                             JOIN Users u ON r.user_id = u.user_id
                             JOIN Books b ON r.book_id = b.book_id
                             ORDER BY r.reservation_date DESC";

                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvReservations.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmViewReservations_Load(object sender, EventArgs e)
        {

        }

        private void dgvReservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
