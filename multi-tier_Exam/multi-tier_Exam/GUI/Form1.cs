using multi_tier_Exam.BAC;
using multi_tier_Exam.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multi_tier_Exam
{
    public partial class Form1 : Form
    {
        private MovieManager mService = new MovieManager();
        private DirectorManager dService = new DirectorManager();
        private AssignmentManager aService = new AssignmentManager();

        public Form1()
        {
            InitializeComponent();
            LoadMovies();
            LoadDirectors();
            LoadMovieDirectors();
        }

        public void LoadMovies()
        {
            dataGridView1.DataSource = mService.getAllMovies();
        }

        public void LoadDirectors()
        {
            dataGridView2.DataSource = dService.getAllDirectors();
        }

        public void LoadMovieDirectors()
        {
            dataGridView3.DataSource = aService.getAll();

            var movie = mService.getAllMovies();
            comboBox1.DataSource = movie;
            comboBox1.DisplayMember = "title";
            comboBox1.ValueMember = "MovieID";

            var director = dService.getAllDirectors();
            comboBox2.DataSource = director;
            comboBox2.DisplayMember = "firstName";
            comboBox2.ValueMember = "DirectorID";
        }



        private void button7_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);

            dService.RemoveDirector(id);
            LoadDirectors();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string title = textBox2.Text;
            string genre = textBox3.Text;
            string releaseYear = textBox4.Text;
            string duration = textBox5.Text;

            mService.AddMovies(id, title, genre, releaseYear, duration);
            LoadMovies();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            string title = textBox2.Text;
            string genre = textBox3.Text;
            string releaseYear = textBox4.Text;
            string duration = textBox5.Text;

            mService.UpdateMovie(id, title, genre, releaseYear, duration);
            LoadMovies();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);
            string firstName = textBox7.Text;
            string lastName = textBox8.Text;

            dService.AddDirector(id, firstName, lastName);
            LoadDirectors();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox6.Text);
            string firstName = textBox7.Text;
            string lastName = textBox8.Text;

            dService.UpdateDirector(id, firstName, lastName);
            LoadDirectors();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);

            mService.RemoveMovies(id);
            LoadMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int assignID = Convert.ToInt32(textBox9.Text);
            int movieID = Convert.ToInt32(comboBox1.SelectedValue);
            int directorID = Convert.ToInt32(comboBox2.SelectedValue);

            aService.addAssign(assignID, movieID, directorID);
            LoadMovieDirectors();
        }
    }
}
