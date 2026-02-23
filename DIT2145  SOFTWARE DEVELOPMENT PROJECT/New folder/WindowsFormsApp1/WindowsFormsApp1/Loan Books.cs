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
    public partial class frmloanbook : Form
    {
        public frmloanbook()
        {
            InitializeComponent();
        }

        private void btnaddBook_Click(object sender, EventArgs e)
        {

            string userId = txtUserId.Text;
            string copyId = txtCopyId.Text;

            string connectionString = Connection.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string userTypeQuery = "SELECT type FROM Users WHERE user_id = @user_id";
            SqlCommand userTypeCommand = new SqlCommand(userTypeQuery, connection);
            userTypeCommand.Parameters.AddWithValue("@user_id", userId);

            object userTypeResult = userTypeCommand.ExecuteScalar();

            if (userTypeResult != null)
            {
                string userType = userTypeResult.ToString();

                if (userType.Equals("visitor", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Visitors are not allowed to perform this action.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("User not found.");
                return;
            }

            string referenceCheckQuery = "SELECT is_reference, status FROM Copies WHERE copy_id = @copy_id";
            SqlCommand referenceCommand = new SqlCommand(referenceCheckQuery, connection);
            referenceCommand.Parameters.AddWithValue("@copy_id", copyId);

            using (SqlDataReader reader = referenceCommand.ExecuteReader())
            {
                if (reader.Read())
                {
                    bool isReference = reader.GetBoolean(0);
                    string copyStatus = reader.GetString(1);

                    if (isReference)
                    {
                        MessageBox.Show("This copy can't be loaned because it is reference only.");
                        connection.Close();
                        return;
                    }
                    if (copyStatus != "available")
                    {
                        MessageBox.Show("This copy can't be loaned because it is " + copyStatus + ".");
                        connection.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Copy Id.");
                    return;
                }
            }

            string loanCountQuery = "SELECT COUNT(*) FROM Loans WHERE user_id = @user_id AND status = 'active'";
            SqlCommand countCommand = new SqlCommand(loanCountQuery, connection);
            countCommand.Parameters.AddWithValue("@user_id", userId);
            int currentLoans = (int)countCommand.ExecuteScalar();

            if (currentLoans >= 5)
            {
                MessageBox.Show("You cannot borrow more than 5 books at a time. Please return an overdue book.");
                connection.Close();
                return;
            }

            string insertLoanQuery = "INSERT INTO Loans (user_id, copy_id, loan_date, status) VALUES (@user_id, @copy_id, @loan_date, 'active')";
            SqlCommand loanCommand = new SqlCommand(insertLoanQuery, connection);
            loanCommand.Parameters.AddWithValue("@user_id", userId);
            loanCommand.Parameters.AddWithValue("@copy_id", copyId);
            loanCommand.Parameters.AddWithValue("@loan_date", DateTime.Now);

            loanCommand.ExecuteNonQuery();

            string updateCopyQuery = "UPDATE Copies SET status = 'loaned' WHERE copy_id = @copy_id";
            SqlCommand updateCopyCommand = new SqlCommand(updateCopyQuery, connection);
            updateCopyCommand.Parameters.AddWithValue("@copy_id", copyId);

            updateCopyCommand.ExecuteNonQuery();

            MessageBox.Show("Loan confirmed. Please return the book in two weeks.");
            connection.Close();
           

           

        }

        private void frmloanbook_Load(object sender, EventArgs e)
        {

        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            frmViewLoanBooks frmViewLoanBooks = new frmViewLoanBooks();
            frmViewLoanBooks.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            frmLibrary frmLibrary = new frmLibrary();

            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
