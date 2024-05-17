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

namespace UniversityLibraryFormsCSQL
{
    public partial class AddAuthor : Form
    {
        string connString = "Data Source=DESKTOP-BC6SQGP\\SQLEXPRESS;Initial Catalog = UniversityLibrary; Integrated Security = True;";
        public AddAuthor()
        {
            InitializeComponent();
        }

        private void AddAuthor_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Generate the next AUTHOR_ID
                int nextAuthorId = GetNextAuthorId(connection);

                string sql = "INSERT INTO AUTHOR (AUTHOR_ID, A_FIRST_NAME, A_LAST_NAME) VALUES (@AuthorId, @FirstName, @LastName)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@AuthorId", nextAuthorId);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Author added successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add author.");
                    }
                }
            }
        }

        private int GetNextAuthorId(SqlConnection connection)
        {
            string query = "SELECT ISNULL(MAX(AUTHOR_ID), 0) + 1 FROM AUTHOR";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // If no records are found, return 1 as the initial author ID
                    return 1;
                }
            }
        }

    }
}
