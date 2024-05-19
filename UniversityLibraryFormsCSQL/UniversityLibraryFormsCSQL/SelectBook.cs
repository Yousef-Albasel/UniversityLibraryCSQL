using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityLibraryFormsCSQL
{
    public partial class SelectBook : Form
    {
        public SelectBook()
        {
            InitializeComponent();
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
                    // Enable for Book
                    BookNameTextBox.Enabled = true;
                    ISBNTextBox.Enabled = true;
                    LanguageTextBox.Enabled = true;
                    CategoryTextBox.Enabled = true;
                    AvailableCheckBox.Enabled = true;
                    FirstNameTextBox.Enabled = false;
                    LastNameTextBox.Enabled = false;
                    PublisherNameTextBox.Enabled = false;
                    PublicationYearTextBox.Enabled = false;
                    break;
                case "Author":
                    // Enable  for Author
                    FirstNameTextBox.Enabled = true;
                    LastNameTextBox.Enabled = true;
                    // Disable to Book and Publisher
                    BookNameTextBox.Enabled = false;
                    ISBNTextBox.Enabled = false;
                    LanguageTextBox.Enabled = false;
                    CategoryTextBox.Enabled = false;
                    AvailableCheckBox.Enabled = false;
                    PublisherNameTextBox.Enabled = false;
                    PublicationYearTextBox.Enabled = false;
                    break;
                case "Publisher":
                    // Enables for Publisher
                    PublisherNameTextBox.Enabled = true;
                    PublicationYearTextBox.Enabled = true;
                    // Disable  to Book and Author
                    BookNameTextBox.Enabled = false;
                    ISBNTextBox.Enabled = false;
                    LanguageTextBox.Enabled = false;
                    CategoryTextBox.Enabled = false;
                    AvailableCheckBox.Enabled = false;
                    FirstNameTextBox.Enabled = false;
                    LastNameTextBox.Enabled = false;
                    break;
                case "Multiple":
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Enabled = true;
                        }
                    }
                    CategoryTextBox.Enabled = true;
                    AvailableCheckBox.Enabled = true;

                    break;
                default:
                    foreach (Control c in this.Controls)
                    {
                        if (c is TextBox)
                        {
                            ((TextBox)c).Enabled = false;
                        }
                    }
                    CategoryTextBox.Enabled = false;
                    AvailableCheckBox.Enabled = false;

                    break;
            }
        }
    }

  public SelectBook()
        {
            InitializeComponent();
        }

        private void SelectBook_Load(object sender, EventArgs e)
        {
        
            TableSelection.Items.AddRange(new string[] { "Books", "Authors", "Fines" });
        }

        private void TableSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Display fields based on the selected table
            switch (TableSelection.SelectedItem.ToString())
            {
                case "Books":
                    EnableBookFields(true);
                    EnableAuthorFields(false);
                    EnableFinesFields(false);
                    break;
                case "Authors":
                    EnableBookFields(false);
                    EnableAuthorFields(true);
                    EnableFinesFields(false);
                    break;
                case "Fines":
                    EnableBookFields(false);
                    EnableAuthorFields(false);
                    EnableFinesFields(true);
                    break;
                default:
                    break;
            }
        }

        private void FetchDataButton_Click(object sender, EventArgs e)
        {
            string selectedTable = TableSelection.SelectedItem.ToString();
            DataTable data = null;

            switch (selectedTable)
            {
                case "Books":
                    data = GetBookData();
                    break;
                case "Authors":
                    data = GetAuthorData();
                    break;
                case "Fines":
                    data = GetFinesData();
                    break;
                default:
                    MessageBox.Show("Please select a valid table.");
                    break;
            }

            ResultsDataGridView.DataSource = data;
        }

        private DataTable GetBookData()
        {
            string query = "SELECT * FROM Books WHERE 1=1";
            if (!string.IsNullOrEmpty(BookNameTextBox.Text))
            {
                query += $" AND BookName = '{BookNameTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(ISBNTextBox.Text))
            {
                query += $" AND ISBN = '{ISBNTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(LanguageTextBox.Text))
            {
                query += $" AND Language = '{LanguageTextBox.Text}'";
            }
            return ExecuteQuery(query);
        }

        private DataTable GetAuthorData()
        {
            string query = "SELECT * FROM Authors WHERE 1=1";
            if (!string.IsNullOrEmpty(FirstNameTextBox.Text))
            {
                query += $" AND FirstName = '{FirstNameTextBox.Text}'";
            }
            if (!string.IsNullOrEmpty(LastNameTextBox.Text))
            {
                query += $" AND LastName = '{LastNameTextBox.Text}'";
            }
            return ExecuteQuery(query);
        }

      //  private DataTable GetFinesData(){}
        
   

        private DataTable ExecuteQuery(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return dataTable;
        }
  
}
