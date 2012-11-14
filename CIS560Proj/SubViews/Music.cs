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
    public partial class Music : Form
    {
        public Music()
        {
            InitializeComponent();
        }

        private void Music_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaDB.Music' table. You can move, or remove it, as needed.
            this.musicTableAdapter.Music(this.mediaDB.Music);
            // TODO: This line of code loads data into the 'mediaDB.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Games(this.mediaDB.Games);

        }
    }
}
