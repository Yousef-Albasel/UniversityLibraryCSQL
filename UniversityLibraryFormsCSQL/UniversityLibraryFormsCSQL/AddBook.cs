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
        string connString = ConnectionStringHelper.ConnectionString;
        public AddBook()
        {
            InitializeComponent();
            List<string> categories = FetchCategoriesFromDatabase("BOOK_CATEGORY","CATEGORY");
            foreach (var category in categories)
            {
                CategoryCombo.Items.Add(category);
            }
            List<string> authors = FetchCategoriesFromDatabase("AUTHOR","A_FIRST_NAME");
            foreach (var author in authors)
            {
                AuthorCombo.Items.Add(author);
            }
            List<string> publishers = FetchCategoriesFromDatabase("PUBLISHER","PUBLISHER_NAME");
            foreach (var publisher in publishers)
            {
                PublisherCombo.Items.Add(publisher);
            }
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
            string language = textBox3.Text; // Language
            string isbnStr = textBox5.Text;     // ISBN
            string category = CategoryCombo.Text; // Category
            string authorFName = AuthorCombo.Text;   // Author FName
            string publisherStr = PublisherCombo.Text; // Publisher

            // Validate input
            if (string.IsNullOrWhiteSpace(bookName) ||
                string.IsNullOrWhiteSpace(category) ||
                string.IsNullOrWhiteSpace(language) ||
                string.IsNullOrWhiteSpace(authorFName) ||
                string.IsNullOrWhiteSpace(isbnStr) ||
                string.IsNullOrWhiteSpace(publisherStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            //if (!int.TryParse(authorFName, out int authorId) || authorId <= 0)
            //{
            //    MessageBox.Show("Invalid author ID.");
            //    return;
            //}

            if (!long.TryParse(isbnStr, out long isbn) || isbn <= 0)
            {
                MessageBox.Show("Invalid ISBN.");
                return;
            }

            //if (!int.TryParse(publisherIdStr, out int publisherId) || publisherId <= 0)
            //{
            //    MessageBox.Show("Invalid publisher ID.");
            //    return;
            //}

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
            string connectionString = connString;
            // SQL INSERT command
            string sql = "INSERT INTO BOOKS (BOOK_NAME, LANGUAGE, AUTHOR_ID, ISBN, PUBLISHER_ID, AVAILABILITY) " +
                         "VALUES (@BookName, @Language, @Author_ID, @ISBN, @PUBLISHER_ID, @Availability)";

            // Using statement to automatically close connection
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Open connection
                connection.Open();

                // Create command
                SqlCommand command = new SqlCommand(sql, connection);

                string authorQuery = "SELECT AUTHOR_ID FROM AUTHOR WHERE A_FIRST_NAME = @AuthorFirstName";
                SqlCommand authorCommand = new SqlCommand(authorQuery, connection);
                authorCommand.Parameters.AddWithValue("@AuthorFirstName", authorFName);
                int? authorId = null;
                try
                {
                    authorId = Convert.ToInt32(authorCommand.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching author ID: {ex.Message}");
                }

                string publisherQuery = "SELECT PUBLISHER_ID FROM PUBLISHER WHERE PUBLISHER_NAME = @PublisherName";
                SqlCommand publisherCommand = new SqlCommand(publisherQuery, connection);
                publisherCommand.Parameters.AddWithValue("@PublisherName", publisherStr);
                int? publisherId = null;
                try
                {
                    publisherId = Convert.ToInt32(publisherCommand.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error fetching publisher ID: {ex.Message}");
                }
                if (authorId.HasValue && publisherId.HasValue)
                {

                    // Add parameters
                    command.Parameters.AddWithValue("@BookName", bookName);
                    command.Parameters.AddWithValue("@Language", language);
                    command.Parameters.AddWithValue("@Author_ID", authorId);
                    command.Parameters.AddWithValue("@PUBLISHER_ID", publisherId);
                    command.Parameters.AddWithValue("@ISBN", isbn);
                    command.Parameters.AddWithValue("@Availability", availability);


                    string bookCategorySql = "INSERT INTO BOOK_CATEGORY (CATEGORY, ISPN) VALUES (@Category, @ISPN)";
                    SqlCommand bookCategoryCommand = new SqlCommand(bookCategorySql, connection);
                    bookCategoryCommand.Parameters.AddWithValue("@Category", category);
                    bookCategoryCommand.Parameters.AddWithValue("@ISPN", isbn);
                    try
                    {
                        int CategotyCommand = Convert.ToInt32(bookCategoryCommand.ExecuteScalar());
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error Adding book to Category: {ex.Message}");
                    }
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

        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<string> FetchCategoriesFromDatabase(string table,string column)
        {
            List<string> categories = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand($"SELECT DISTINCT {column} FROM {table}", connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            categories.Add(reader.GetString(0));
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching categories: {ex.Message}");
            }

            return categories;
        }

        private void AuthorCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }


}
