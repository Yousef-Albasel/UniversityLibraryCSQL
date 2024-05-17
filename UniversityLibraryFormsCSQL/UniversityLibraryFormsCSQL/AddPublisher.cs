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
    public partial class AddPublisher : Form
    {
        string connString = "Data Source=DESKTOP-BC6SQGP\\SQLEXPRESS;Initial Catalog = UniversityLibrary; Integrated Security = True;";
        public AddPublisher()
        {
            InitializeComponent();
        }

        private void AddPublisher_Load(object sender, EventArgs e)
        {

        }
        private void btnAddPublisher_Click(object sender, EventArgs e)
        {
            string publisherName = txtPublisherName.Text;
            string publisherIdStr = txtPublisherId.Text;

            if (string.IsNullOrWhiteSpace(publisherName) || string.IsNullOrWhiteSpace(publisherIdStr))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!int.TryParse(publisherIdStr, out int publisherId) || publisherId <= 0)
            {
                MessageBox.Show("Invalid publisher ID.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                // Check if the publisher ID already exists
                string checkQuery = "SELECT COUNT(*) FROM PUBLISHER WHERE PUBLISHER_ID = @PublisherId";
                using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                {
                    checkCommand.Parameters.AddWithValue("@PublisherId", publisherId);
                    int existingCount = (int)checkCommand.ExecuteScalar();
                    if (existingCount > 0)
                    {
                        MessageBox.Show("Publisher ID already exists. Please choose a different ID.");
                        return;
                    }
                }

                // If the publisher ID is unique, proceed with insertion
                string sql = "INSERT INTO PUBLISHER (PUBLISHER_NAME, PUBLISHER_ID) VALUES (@PublisherName, @PublisherId)";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@PublisherName", publisherName);
                    command.Parameters.AddWithValue("@PublisherId", publisherId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Publisher added successfully!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add publisher.");
                    }
                }
            }
        }

    }
}
