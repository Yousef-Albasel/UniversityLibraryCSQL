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
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get values from text boxes
            string bookName = textBox1.Text; // Book name
            string category = textBox2.Text; // Category
            string language = textBox3.Text; // Language
            string authorIdStr = textBox4.Text;   // Author ID
            string isbnStr = textBox5.Text;     // ISBN
            string publisherIdStr = textBox6.Text; // Publisher ID

            // Validate input
            if (string.IsNullOrWhiteSpace(bookName) ||
                string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(language) ||
                string.IsNullOrWhiteSpace(authorIdStr) ||
                string.IsNullOrWhiteSpace(isbnStr) ||
                string.IsNullOrWhiteSpace(publisherIdStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(authorIdStr, out int authorId) || authorId <= 0)
            {
                MessageBox.Show("Invalid author ID.");
                return;
            }

            if (!long.TryParse(isbnStr, out long isbn) || isbn <= 0)
            {
                MessageBox.Show("Invalid ISBN.");
                return;
            }

            if (!int.TryParse(publisherIdStr, out int publisherId) || publisherId <= 0)
            {
                MessageBox.Show("Invalid publisher ID.");
                return;
            }

            // Determine availability based on radio button selection
            bool? availability = null; // Use nullable bool

            if (radioButton1.Checked)
            {
                availability = true;
            }
            else if (radioButton2.Checked)
            {
                availability = false;
            }

            // Connection string for your database
            string connectionString = "Data Source=DESKTOP-BC6SQGP\\SQLEXPRESS;Initial Catalog=UniversityLibrary;Integrated Security=True";

            // SQL INSERT command
            string sql = "INSERT INTO BOOKS (BOOK_NAME, CATEGORY, LANGUAGE, AUTHOR_ID, ISBN, PUBLISHER_ID, AVAILABILITY) " +
                         "VALUES (@BookName, @Category, @Language, @Author_ID, @ISBN, @PUBLISHER_ID, @Availability)";

            // Using statement to automatically close connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open connection
                connection.Open();

                // Create command
                SqlCommand command = new SqlCommand(sql, connection);

                // Add parameters
                command.Parameters.AddWithValue("@BookName", bookName);
                command.Parameters.AddWithValue("@Category", category);
                command.Parameters.AddWithValue("@Language", language);
                command.Parameters.AddWithValue("@Author_ID", authorId);
                command.Parameters.AddWithValue("@ISBN", isbn);
                command.Parameters.AddWithValue("@PUBLISHER_ID", publisherId);
                command.Parameters.AddWithValue("@Availability", availability);

                // Execute command
                int rowsAffected = command.ExecuteNonQuery();

                // Check if insertion was successful
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book added successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add book.");
                }

            }
        }
    }
}
