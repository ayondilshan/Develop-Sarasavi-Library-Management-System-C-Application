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
    public partial class frmBookO : Form
    {
        public frmBookO()
        {
            InitializeComponent();
        }

        private void btnaddBook_Click(object sender, EventArgs e)
        {
            string bookId = txtBookId.Text;
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string isbn = txtIsbn.Text;
            string classification = txtClassification.Text;
            string totalCopies = txtTotalC.Text;
            string referenceCopies = txtTotalR.Text;

            if (int.TryParse(totalCopies, out int total_quantity))
            {
                if (total_quantity > 10)
                {
                    MessageBox.Show("Maximum 10 Total Copies are allowed");
                }
                else
                {
                    if (int.TryParse(referenceCopies, out int reference_quantity))
                    {

                        string connectionString = Connection.connectionString;
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        string query = "INSERT INTO Books (book_id, title, isbn, author, classification, total, reference) VALUES (@book_id, @title, @isbn, @author, @classification, @total, @reference)";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@book_id", bookId);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@isbn", isbn);
                        command.Parameters.AddWithValue("@author", author);
                        command.Parameters.AddWithValue("@classification", classification);
                        command.Parameters.AddWithValue("@total", total_quantity);
                        command.Parameters.AddWithValue("@reference", reference_quantity);

                        command.ExecuteNonQuery();

                        for (int i = 0; i < total_quantity; i++)
                        {
                            bool isReference = i < reference_quantity;
                            string copyQuery = "INSERT INTO Copies (book_id, is_reference, status) VALUES (@book_id, @isReference, 'available')";
                            SqlCommand copyCommand = new SqlCommand(copyQuery, connection);
                            copyCommand.Parameters.AddWithValue("@book_id", bookId);
                            copyCommand.Parameters.AddWithValue("@isReference", isReference);
                            copyCommand.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Book added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Enter a number in Reference Copies");
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter a number for total copies.");
            }
        
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            txtIsbn.Text = "";
            txtClassification.Text = "";
            txtTotalC.Text = "";
            txtTotalR.Text = "";


            txtBookId.Focus();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            frmViewBooks frmViewBooks = new frmViewBooks();
            frmViewBooks.ShowDialog();
        }
    }
}
