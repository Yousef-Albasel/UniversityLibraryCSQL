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
    public partial class AddCategory : Form
    {
        string connString = ConnectionStringHelper.ConnectionString;
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {

        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string category = txtCategory.Text;
            string isbnStr = txtISBN.Text;

            if (string.IsNullOrWhiteSpace(category) || string.IsNullOrWhiteSpace(isbnStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(isbnStr, out int isbn) || isbn <= 0)
            {
                MessageBox.Show("Invalid ISBN.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connString))
            {
                try
                {
                    connection.Open();

                    // Check if the category for the same ISBN already exists
                    string checkQuery = "SELECT COUNT(*) FROM BOOK_CATEGORY WHERE CATEGORY = @Category AND ISPN = @ISBN";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@Category", category);
                        checkCommand.Parameters.AddWithValue("@ISBN", isbn);
                        int existingCount = (int)checkCommand.ExecuteScalar();
                        if (existingCount > 0)
                        {
                            MessageBox.Show("Category for the same ISBN already exists.");
                            return;
                        }
                    }

                    string sql = "INSERT INTO BOOK_CATEGORY (CATEGORY, ISPN) VALUES (@Category, @ISBN)";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@Category", category);
                        command.Parameters.AddWithValue("@ISBN", isbn);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Category added successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add category.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void AddCategory_Load_1(object sender, EventArgs e)
        {

        }
    }
}
