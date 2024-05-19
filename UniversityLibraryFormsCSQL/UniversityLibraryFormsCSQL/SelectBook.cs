using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryFormsCSQL
{
    public partial class SelectBook : Form
    {
        public Point mouseLocation;
        public SelectBook()
        {
            InitializeComponent();
            List<string> categories = FetchCategoriesFromDatabase("BOOK_CATEGORY", "CATEGORY");
            foreach (var category in categories)
            {
                CategoryTextBox.Items.Add(category);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void firstNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SelectBook_Load(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void TableSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (TableSelection.Text)
            {
                case "Book":
                    EnableBookFields(true);
                    EnableAuthorFields(false);
                    EnablePublisherFields(false);
                    break;
                case "Author":
                    EnableBookFields(false);
                    EnableAuthorFields(true);
                    EnablePublisherFields(false);
                    break;
                case "Publisher":
                    EnableBookFields(false);
                    EnableAuthorFields(false);
                    EnablePublisherFields(true);
                    break;
                case "Multiple":
                    EnableBookFields(true);
                    EnableAuthorFields(true);
                    EnablePublisherFields(true);
                    break;
                default:
                    EnableBookFields(false);
                    EnableAuthorFields(false);
                    EnablePublisherFields(false);
                    break;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void EnableBookFields(bool enable)
        {
            BookNameTextBox.Enabled = enable;
            ISBNTextBox.Enabled = enable;
            LanguageTextBox.Enabled = enable;
            CategoryTextBox.Enabled = enable;
            AvailableCheckBox.Enabled = enable;
        }

        private void EnableAuthorFields(bool enable)
        {
            FirstNameTextBox.Enabled = enable;
            LastNameTextBox.Enabled = enable;
        }

        private void EnablePublisherFields(bool enable)
        {
            PublisherNameTextBox.Enabled = enable;
            PublicationYearTextBox.Enabled = enable;
        }

        private string BuildQuery(out List<SqlParameter> parameters)
        {
            StringBuilder query = new StringBuilder(@"
                            SELECT 
                                BOOKS.ISBN, 
                                BOOKS.BOOK_NAME, 
                                BOOKS.AVAILABILITY, 
                                AUTHOR.A_FIRST_NAME, 
                                AUTHOR.A_LAST_NAME, 
                                PUBLISHER.PUBLISHER_NAME, 
                                BOOK_CATEGORY.CATEGORY 
                            FROM BOOKS 
                            JOIN AUTHOR ON BOOKS.AUTHOR_ID = AUTHOR.AUTHOR_ID 
                            JOIN PUBLISHER ON BOOKS.PUBLISHER_ID = PUBLISHER.PUBLISHER_ID 
                            JOIN BOOK_CATEGORY ON BOOKS.ISBN = BOOK_CATEGORY.ISPN 
                            WHERE 1=1 ");

            parameters = new List<SqlParameter>();

            if (!string.IsNullOrEmpty(BookNameTextBox.Text))
            {
                query.Append("AND BOOKS.BOOK_NAME LIKE @BookName ");
                parameters.Add(new SqlParameter("@BookName", $"%{BookNameTextBox.Text}%"));
            }

            if (!string.IsNullOrEmpty(ISBNTextBox.Text))
            {
                query.Append("AND BOOKS.ISBN = @ISBN ");
                parameters.Add(new SqlParameter("@ISBN", ISBNTextBox.Text));
            }

            if (!string.IsNullOrEmpty(LanguageTextBox.Text))
            {
                query.Append("AND BOOKS.LANGUAGE = @Language ");
                parameters.Add(new SqlParameter("@Language", LanguageTextBox.Text));
            }

            if (!string.IsNullOrEmpty(CategoryTextBox.Text))
            {
                query.Append("AND BOOK_CATEGORY.CATEGORY LIKE @CategoryName ");
                parameters.Add(new SqlParameter("@CategoryName", $"%{CategoryTextBox.Text}%"));
            }

            if (AvailableCheckBox.Checked)
            {
                query.Append("AND BOOKS.AVAILABILITY = 1 ");
            }
            else
            {
                query.Append("AND BOOKS.AVAILABILITY = 0 ");
            }

            if (!string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                query.Append("AND AUTHOR.A_FIRST_NAME LIKE @FirstName ");
                parameters.Add(new SqlParameter("@FirstName", $"%{FirstNameTextBox.Text}%"));
            }

            if (!string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                query.Append("AND AUTHOR.A_LAST_NAME LIKE @LastName ");
                parameters.Add(new SqlParameter("@LastName", $"%{LastNameTextBox.Text}%"));
            }

            if (!string.IsNullOrEmpty(PublisherNameTextBox.Text))
            {
                query.Append("AND PUBLISHER.PUBLISHER_NAME LIKE @PublisherName ");
                parameters.Add(new SqlParameter("@PublisherName", $"%{PublisherNameTextBox.Text}%"));
            }

            return query.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query;
            string JoinedQuery;
            List<SqlParameter> parameters;
            JoinedQuery = BuildQuery(out parameters);
            switch (TableSelection.Text)
            {
                case "Book":
                    query = GetBookData();
                    break;
                case "Author":
                    query = GetAuthorData();
                    break;
                case "Publisher":
                    query = GetPublisherData();
                    break;
                case "Multiple":
                    query = JoinedQuery;
                    break;
                default:
                    query = "";
                    break;
            }
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter at least one search criteria.");
                return;
            }

            string connectionString = ConnectionStringHelper.ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                foreach (SqlParameter param in parameters)
                {
                    command.Parameters.Add(param);
                }

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UserDashboard ud = new UserDashboard();
            ud.Show();
            this.Close();
        }


        private string GetBookData()
        {
            string query = "SELECT * FROM BOOKS JOIN BOOK_CATEGORY ON BOOKS.ISBN = BOOK_CATEGORY.ISPN WHERE 1=1";
            if (!string.IsNullOrEmpty(BookNameTextBox.Text))
            {
                query += $" AND BOOK_NAME= '{BookNameTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(ISBNTextBox.Text))
            {
                query += $" AND ISBN = '{ISBNTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(LanguageTextBox.Text))
            {
                query += $" AND LANGUAGE = '{LanguageTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(CategoryTextBox.Text))
            {
                query += $" AND CATEGORY = '{CategoryTextBox.Text}'";
            }
            return query;
        }

        private string GetAuthorData()
        {
            string query = "SELECT * FROM AUTHOR WHERE 1=1";
            if (!string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                query += $" AND A_FIRST_NAME = '{FirstNameTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                query += $" AND A_LAST_NAME = '{LastNameTextBox.Text}'";
            }
            return query;
        }

        private string GetPublisherData()
        {
            string query = "SELECT * FROM PUBLISHER WHERE 1=1";
            if (!string.IsNullOrEmpty(PublisherNameTextBox.Text))
            {
                query += $" AND PUBLISHER_NAME = '{FirstNameTextBox.Text}'";
            }

            return query;
        }

        private List<string> FetchCategoriesFromDatabase(string table, string column)
        {
            List<string> categories = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionStringHelper.ConnectionString))
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

        private void CategoryTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookNameTextBox.Text = string.Empty;
            ISBNTextBox.Text = string.Empty;
            LanguageTextBox.Text = string.Empty;
            CategoryTextBox.Text = string.Empty;
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            PublisherNameTextBox.Text = string.Empty;
            PublicationYearTextBox.Text = string.Empty;
            
            AvailableCheckBox.Checked = false;
            CategoryTextBox.SelectedIndex = -1;
            TableSelection.SelectedIndex = -1; 

        }
    }

}
