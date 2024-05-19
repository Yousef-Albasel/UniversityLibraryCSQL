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
        public Point mouseLocation;
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
            DeleteBook delBook = new DeleteBook();
            delBook.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateBook update = new UpdateBook();
            update.Show();

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteUser delUser = new DeleteUser();
            delUser.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BrowseBooks broBooks = new BrowseBooks();
            broBooks.Show();
        }

        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Close();
        }

        private void DeleteBookBtn_Click(object sender, EventArgs e)
        {
            DeleteBook delBook = new DeleteBook();
            delBook.Show();
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            BrowseBooks broBooks = new BrowseBooks();
            broBooks.Show();
        }

        private void DelUserBtn_Click(object sender, EventArgs e)
        {
            DeleteUser delUser = new DeleteUser();
            delUser.Show();
            this.Close();
        }

        private void AddBookBtn_Click_1(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();
            this.Close();
        }

        private void UpdateUserBtn_Click(object sender, EventArgs e)
        {
            UpdateUserDetails upUser = new UpdateUserDetails();
            upUser.Show();
            this.Close();
        }

        private void UpdateBookBtn_Click(object sender, EventArgs e)
        {
            UpdateBook upBook = new UpdateBook();
            upBook.Show();
            this.Close();

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
