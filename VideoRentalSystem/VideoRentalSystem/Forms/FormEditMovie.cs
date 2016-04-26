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
    //Form to edit movie info.
    public partial class FormEditMovie : Form
    {
        private int ID;
        public FormEditMovie(string Title, string Year, string Genre, string Rating, string plot, int ID)
        {
            InitializeComponent();
    
            txtTitle.Text = Title;
            cmbxGenre.Text = Genre;
            cmbxRating.Text = Rating;
            txtPlot.Text = plot;
            this.ID = ID;
            try
            {
                dateTimePicker.Value = new DateTime(Convert.ToInt32(Year), 01, 01);
            }
            catch (Exception)
            {
                //throw;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var myData = new Data();
            myData.EditMovie(txtTitle.Text, txtPlot.Text, dateTimePicker.Text, cmbxRating.Text, cmbxGenre.Text, ID);
            MessageBox.Show("Movie Updated");
            this.Close();
        }
    }
}
