using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using Cineplexx.Properties;

namespace Cineplexx
{


    public partial class Form1 : Form
    {

        
        List<Movie> listofMovies = null;
        List<Time> listofTimes = null;



        Movie currentmovie = null;
        Time currenttime = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listBoxmoviedetail.Items.Clear();
            if(this.listofMovies.Count > 0)
            {
                foreach (Movie item in this.listofMovies)
                {
                    this.listBoxmoviedetail.Items.Add(item);
                }
            }
        }

        private void actortextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttoninsert_Click(object sender, EventArgs e)
        {
            //try
            //{
                currentmovie = new Movie();

                currentmovie.MovieCode = int.Parse(this.moviecodetextbox.Text);
                currentmovie.Titile = this.titletextbox.Text;
                currentmovie.ActorName = this.actortextbox.Text;

                currenttime = new Time();
                currenttime.MovieTime = new Time(Convert.ToInt32(this.textBoxDurationhours),
                                                  Convert.ToInt32(this.textBoxDurationminute));



                listofMovies.Add(currentmovie);
                currentmovie.languages = (EnumLanguage)this.comboBoxLanguage.SelectedIndex;
                currentmovie.MoviesLanguage = (EnumLanguage)this.comboBoxLanguage.SelectedIndex;

            currentmovie.MovieType = (EnumType)this.comboBoxtype.SelectedIndex;
            currentmovie.MovieType = (EnumType)this.comboBoxtype.SelectedIndex;

            listofTimes.Add(currenttime);

            listofMovies.Add(currentmovie);



            // }
            //catch (FormatException formatException)
            // {
            // MessageBox.Show("Format exception..." + formatException.Message);


            //}
        }

        private void listBoxmoviedetail_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listofMovies = new List<Movie>();
            foreach(EnumLanguage item in Enum.GetValues(typeof(EnumLanguage)))
            {
                this.comboBoxLanguage.Items.Add(item);
            }
            comboBoxLanguage.Text = comboBoxLanguage.Items[2].ToString();
            comboBoxLanguage.Text = Convert.ToString(comboBoxLanguage.Items[2].ToString());

            listofMovies = new List<Movie>();
            foreach (EnumType item in Enum.GetValues(typeof(EnumType)))
            {
                this.comboBoxtype.Items.Add(item);
            }
            comboBoxtype.Text = comboBoxLanguage.Items[2].ToString();
            comboBoxtype.Text = Convert.ToString(comboBoxLanguage.Items[2].ToString());
        }

        private void buttonreset_Click(object sender, EventArgs e)
        {

        }
    }
}
