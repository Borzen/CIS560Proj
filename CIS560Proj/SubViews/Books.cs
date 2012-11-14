using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS560Proj
{
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaDB.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Books(this.mediaDB.Books);
            // TODO: This line of code loads data into the 'mediaDB.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Books(this.mediaDB.Books);
        }
    }
}
