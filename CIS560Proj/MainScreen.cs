using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace CIS560Proj
{
    public partial class MainScreen : Form
    {

        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mediaDB.Media' table. You can move, or remove it, as needed.
            this.mediaTableAdapter.Media(this.mediaDB.Media);
        }

        private void BookB_Click(object sender, EventArgs e)
        {
            Books b = new Books();
            b.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //Search search = new Search();
            //search.Show();
        }

        private void SongB_Click(object sender, EventArgs e)
        {
            Music m = new Music();
            m.Show();
        }

        private void MoviesB_Click(object sender, EventArgs e)
        {
            Movies m = new Movies();
            m.Show();
        }

        private void GamesB_Click(object sender, EventArgs e)
        {
            Games g = new Games();
            g.Show();
        }

        private void PhysicalB_Click(object sender, EventArgs e)
        {
            Physical p = new Physical();
            p.Show();
        }

        private void DigitalB_Click(object sender, EventArgs e)
        {
            Digital d = new Digital();
            d.Show();
        }
        
    }
}
