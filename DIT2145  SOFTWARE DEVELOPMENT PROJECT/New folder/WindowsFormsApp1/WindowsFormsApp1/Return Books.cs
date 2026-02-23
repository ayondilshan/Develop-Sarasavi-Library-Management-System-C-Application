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
    public partial class frmReturnBooks : Form
    {
        public frmReturnBooks()
        {
            InitializeComponent();
        }

        private void btnaddBook_Click(object sender, EventArgs e)
        {
            string user_id = txtuserId.Text;
            string copy_id = txtCopyId.Text;

            string connectionString = Connection.connectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // 1️⃣ Get active loan for this copy along with user_id
                string checkLoanQuery = "SELECT loan_id, user_id FROM Loans WHERE copy_id = @copy_id AND status = 'active'";
                SqlCommand checkLoanCommand = new SqlCommand(checkLoanQuery, connection);
                checkLoanCommand.Parameters.AddWithValue("@copy_id", copy_id);

                SqlDataReader reader = checkLoanCommand.ExecuteReader();

                if (reader.Read())
                {
                    object loanId = reader["loan_id"];
                    string userId = reader["user_id"].ToString(); 
                    reader.Close();

                   
                    string getBookIdQuery = "SELECT book_id FROM Copies WHERE copy_id = @copy_id";
                    SqlCommand getBookIdCommand = new SqlCommand(getBookIdQuery, connection);
                    getBookIdCommand.Parameters.AddWithValue("@copy_id", copy_id);

                    object book_id = getBookIdCommand.ExecuteScalar();

                  
                    string checkReservationQuery = "SELECT TOP 1 user_id FROM Reservations WHERE book_id = @book_id ORDER BY reservation_date";
                    SqlCommand checkReservationCommand = new SqlCommand(checkReservationQuery, connection);
                    checkReservationCommand.Parameters.AddWithValue("@book_id", book_id);

                    object reservationUserId = checkReservationCommand.ExecuteScalar();

                   
                    string returnUpdateQuery = "UPDATE Loans SET return_date = @return_date, status = 'completed' WHERE loan_id = @loan_id";
                    SqlCommand returnUpdateCommand = new SqlCommand(returnUpdateQuery, connection);
                    returnUpdateCommand.Parameters.AddWithValue("@return_date", DateTime.Now);
                    returnUpdateCommand.Parameters.AddWithValue("@loan_id", loanId);
                    returnUpdateCommand.ExecuteNonQuery();

                  
                    string updateCopyQuery = "UPDATE Copies SET status = 'available' WHERE copy_id = @copy_id";
                    SqlCommand updateCopyCommand = new SqlCommand(updateCopyQuery, connection);
                    updateCopyCommand.Parameters.AddWithValue("@copy_id", copy_id);
                    updateCopyCommand.ExecuteNonQuery();

                    MessageBox.Show("Book returned successfully by User ID: " + userId);

                    if (reservationUserId != null)
                    {
                        MessageBox.Show("The copy has been reserved for User ID: " + reservationUserId + ". Keep it for them.");

                        string deleteReservationQuery = "DELETE FROM Reservations WHERE user_id = @reservationUserId AND book_id = @book_id";
                        SqlCommand deleteReservationCommand = new SqlCommand(deleteReservationQuery, connection);
                        deleteReservationCommand.Parameters.AddWithValue("@reservationUserId", reservationUserId);
                        deleteReservationCommand.Parameters.AddWithValue("@book_id", book_id);
                        deleteReservationCommand.ExecuteNonQuery();
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("This loan does not exist or has already been returned.");
                }
            }
        }

        private void frmReturnBooks_Load(object sender, EventArgs e)
        {

        }

        private void btnViewReturn_Click(object sender, EventArgs e)
        {
            frmViewReturnBooks viewForm = new frmViewReturnBooks();
            viewForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLibrary frmLibrary = new frmLibrary();

            this.Hide();
        }
    }
}
