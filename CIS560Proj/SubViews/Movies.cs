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
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        private void Movies_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaDB.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Movies(this.mediaDB.Movies);

        }
    }
}
