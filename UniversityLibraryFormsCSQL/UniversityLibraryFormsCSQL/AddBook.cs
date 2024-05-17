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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversityLibraryFormsCSQL
{
    public partial class AddBook : Form
    {
        string connString = "Data Source=DESKTOP-BC6SQGP\\SQLEXPRESS;Initial Catalog = UniversityLibrary; Integrated Security = True;";
        public AddBook()
        {
            InitializeComponent();
            LoadCategories();
            LoadAuthors();
            LoadPublishers();
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthor addAuthorForm = new AddAuthor();
            addAuthorForm.FormClosed += new FormClosedEventHandler(AddAuthorForm_FormClosed);
            addAuthorForm.ShowDialog();
        }

        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            AddPublisher addPublisherForm = new AddPublisher();
            addPublisherForm.FormClosed += new FormClosedEventHandler(AddPublisherForm_FormClosed);
            addPublisherForm.ShowDialog();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategoryForm = new AddCategory();
            addCategoryForm.FormClosed += new FormClosedEventHandler(AddCategoryForm_FormClosed);
            addCategoryForm.ShowDialog();
        }

        private void AddAuthorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorCombo.Items.Clear();
            LoadAuthors();
        }

        private void AddPublisherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PublisherCombo.Items.Clear();
            LoadPublishers();
        }

        private void AddCategoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CategoryCombo.Items.Clear();
            LoadCategories();
        }

        private void LoadAuthors()
        {
            AuthorCombo.Items.Clear();
            List<string> authors = FetchCategoriesFromDatabase("AUTHOR", "A_FIRST_NAME");
            foreach (var author in authors)
            {
                AuthorCombo.Items.Add(author);
            }
            AuthorCombo.Items.Add("Add New Author...");
        }

        private void LoadPublishers()
        {
            List<string> publishers = FetchCategoriesFromDatabase("PUBLISHER", "PUBLISHER_NAME");
            foreach (var publisher in publishers)
            {
                PublisherCombo.Items.Add(publisher);
            }
        }

        private void LoadCategories()
        {
            List<string> categories = FetchCategoriesFromDatabase("BOOK_CATEGORY", "CATEGORY");
            foreach (var category in categories)
            {
                CategoryCombo.Items.Add(category);
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
            string authorFName = AuthorCombo.Text;   // Author FName
            string publisherStr = PublisherCombo.Text; // Publisher

            // Validate input
            if (string.IsNullOrWhiteSpace(bookName) ||
                string.IsNullOrWhiteSpace(language) ||
                string.IsNullOrWhiteSpace(authorFName) ||
                string.IsNullOrWhiteSpace(isbnStr) ||
                string.IsNullOrWhiteSpace(publisherStr) ||
                CategoryCombo.SelectedIndex == -1) // Ensure a category is selected
            {
                MessageBox.Show("Please fill in all fields and select a category.");
                return;
            }

            string category = CategoryCombo.SelectedItem.ToString(); // Retrieve selected category

            if (!long.TryParse(isbnStr, out long isbn) || isbn <= 0)
            {
                MessageBox.Show("Invalid ISBN.");
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
            string connectionString = connString;
            // SQL INSERT command
            string sql = "INSERT INTO BOOKS (BOOK_NAME, LANGUAGE, AUTHOR_ID, ISBN, PUBLISHER_ID, CATEGORY, AVAILABILITY) " +
                         "VALUES (@BookName, @Language, @Author_ID, @ISBN, @PUBLISHER_ID, @Category, @Availability)";

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
                    command.Parameters.AddWithValue("@Category", category); // Add category parameter
                    command.Parameters.AddWithValue("@ISBN", isbn);
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


        private void CategoryCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<string> FetchCategoriesFromDatabase(string table, string column)
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