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
}
