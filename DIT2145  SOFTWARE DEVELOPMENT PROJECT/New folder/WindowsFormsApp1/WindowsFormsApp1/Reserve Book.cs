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
    public partial class frmReserveBook : Form
    {
        public frmReserveBook()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {


            frmLibrary frmLibrary = new frmLibrary();
          
            this.Hide();
        }

        private void frmReserveBook_Load(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int userId, bookId;

                if (!int.TryParse(txtUserID.Text, out userId) ||
                    !int.TryParse(txtBookID.Text, out bookId))
                {
                    MessageBox.Show("Please enter valid numeric IDs!");
                    return;
                }

                using (SqlConnection con = new SqlConnection(Connection.connectionString))
                {
                    con.Open();

                    
                    SqlCommand cmdUser = new SqlCommand(
                        "SELECT COUNT(*) FROM Users WHERE user_id=@uid", con);
                    cmdUser.Parameters.AddWithValue("@uid", userId);

                    if ((int)cmdUser.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("User not found!");
                        return;
                    }

                    // BOOK CHECK
                    SqlCommand cmdBook = new SqlCommand(
                        "SELECT COUNT(*) FROM Books WHERE book_id=@bid", con);
                    cmdBook.Parameters.AddWithValue("@bid", bookId);

                    if ((int)cmdBook.ExecuteScalar() == 0)
                    {
                        MessageBox.Show("Book not found!");
                        return;
                    }

                    // DUPLICATE CHECK
                    SqlCommand cmdDup = new SqlCommand(
                        "SELECT COUNT(*) FROM Reservations WHERE user_id=@uid AND book_id=@bid AND status='Pending'", con);
                    cmdDup.Parameters.AddWithValue("@uid", userId);
                    cmdDup.Parameters.AddWithValue("@bid", bookId);

                    if ((int)cmdDup.ExecuteScalar() > 0)
                    {
                        MessageBox.Show("Already reserved!");
                        return;
                    }

                    // INSERT
                    SqlCommand cmdInsert = new SqlCommand(
                        "INSERT INTO Reservations(user_id, book_id, status) VALUES(@uid,@bid,'Pending')", con);
                    cmdInsert.Parameters.AddWithValue("@uid", userId);
                    cmdInsert.Parameters.AddWithValue("@bid", bookId);

                    cmdInsert.ExecuteNonQuery();

                    MessageBox.Show("Reservation Successful!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            frmViewReservations f = new frmViewReservations();
            f.Show();
        }
    }
    }

