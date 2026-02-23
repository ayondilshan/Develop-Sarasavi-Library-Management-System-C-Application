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
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class frmUserO : Form
    {
        public frmUserO()
        {
            InitializeComponent();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            frmViewUsers frmViewUsers = new frmViewUsers();
            frmViewUsers.ShowDialog();
        }
       
        private void button_usersave_Click(object sender, EventArgs e)
        {
            {
                string user_id = txtUserId.Text;
                string name = txtName.Text;
                string nic = txtNic.Text;

                string gender = chkMale.Checked ? "male" : "female";
                string address = txtAddress.Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(Connection.connectionString))

                    {
                        connection.Open();

                        string query = @"INSERT INTO Users 
                            (user_id, name, gender, nic, address) 
                            VALUES 
                            (@user_id, @name, @gender, @nic, @address , @email)";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@user_id", user_id);
                            command.Parameters.AddWithValue("@name", name);
                            command.Parameters.AddWithValue("@gender", gender);
                            command.Parameters.AddWithValue("@nic", nic);
                            command.Parameters.AddWithValue("@address", address);
                            command.Parameters.AddWithValue("@email", email);

                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("User added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            string user_id = txtUserId.Text;
            string name = txtName.Text;
            string nic = txtNic.Text;
            string gender;
            if (chkMale.Checked)
            {
                gender = "male";
            }
            else
            {
                gender = "female";
            }
            string address = txtAddress.Text;
            string type = cmbUType.Text;


            string connectionString = Connection.connectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Users (user_id, name, gender, nic, address, type,email) VALUES (@user_id, @name, @gender, @nic, @address, @type ,@email)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@user_id", user_id);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@nic", nic);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@type", type);
            command.Parameters.AddWithValue("@email",email);

            command.ExecuteNonQuery();

            connection.Close();

            MessageBox.Show("User added successfully.");
        }
        public static class Connection
        {
            public static string connectionString =
                @"Data Source=DESKTOP-VO1KQCT\SQLEXPRESS;
          Initial Catalog=Sarasavi_Library_DB;
          Integrated Security=True;
          TrustServerCertificate=True;";
        }

        private void cmbUType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmUserO_Load(object sender, EventArgs e)
        {

        }
    }

}

