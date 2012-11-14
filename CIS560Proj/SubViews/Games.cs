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
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaDB.Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Games(this.mediaDB.Games);

        }
    }
}
