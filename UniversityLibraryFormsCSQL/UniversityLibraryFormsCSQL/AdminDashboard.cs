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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBook add = new AddBook();
            add.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateUserDetails updateUser = new UpdateUserDetails();
            updateUser.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BrowseBooks browse = new BrowseBooks();
            browse.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateBook update = new UpdateBook();
            update.Show();

        }
    }
}
