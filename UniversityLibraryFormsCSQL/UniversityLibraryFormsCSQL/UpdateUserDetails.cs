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
    public partial class UpdateUserDetails : Form
    {
        public UpdateUserDetails()
        {
            InitializeComponent();

            textBox3.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Your Information has Changed Successfully");

            if (dialog == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
