using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoRentalSystem.Class;

namespace VideoStore
{
    //Form to add a new movie to database.
    public partial class FormAddMovie : Form
    {
        
        public FormAddMovie()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var myData = new Data();
            myData.AddMovie(txtTitle.Text, txtPlot.Text, dateTimePicker.Text,  cmbxRating.Text, cmbxGenre.Text);
            this.DialogResult = DialogResult.OK;
        }

        //This allows a user to search for movie info and pre fill the form.
        private void button1_Click(object sender, EventArgs e)
        {
            var myData = new Data();
            var myMovie = myData.GetJson(txtTitle.Text);
            if (myMovie.Title != "")
            {
                try
                {
                    txtPlot.Text = myMovie.Plot;
                    cmbxGenre.Text = myMovie.Genre;
                    cmbxRating.Text = myMovie.Rated;
                    dateTimePicker.Value = new DateTime(Convert.ToInt32(myMovie.Year),01,01);
                }
                catch (Exception)
                {
                    MessageBox.Show("Sorry, no info available on this film.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a title first");
            }
        }
    }
}
