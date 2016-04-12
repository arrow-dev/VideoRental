using System;
using System.Windows.Forms;
using VideoRentalSystem.Class;
using VideoStore;

namespace VideoRentalSystem.Forms
{
    public partial class FormDataView : FormTemplate
    {
        public FormDataView()
        {
            InitializeComponent();
        }

        private void FormDataView_Load(object sender, EventArgs e)
        {
            LoadTables();
        }

        public void LoadTables()
        {
            var myData = new Data();
            dgvMovies.DataSource = myData.GetTable("MovieID, title, year, rating, genre", "movies");
            dgvUsers.DataSource = myData.GetTable("*", "customer");
            dgvRentals.DataSource = myData.GetTable("*", "rentedmovies");
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var myData = new Data();
            String myTitle = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            Movie myMovie = myData.GetJson(myTitle);
            //show Movie object
            try
            {
                pbxPoster.LoadAsync(myMovie.Poster);
                lblTitle.Text = myMovie.Title;
                lblPlot.Text = myMovie.Plot;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            var myData = new Data();
            try
            {
                myData.DeleteRecord("Movies", Convert.ToInt32(dgvMovies.SelectedRows[0].Cells[0].Value));
                LoadTables();
            }
            catch (Exception)
            {

            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Form addMovie = new FormAddMovie();
            addMovie.ShowDialog();
            LoadTables();
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            string Title = dgvMovies.SelectedRows[0].Cells[1].Value.ToString();
            string Genre = dgvMovies.SelectedRows[0].Cells[4].Value.ToString();
            string Rating = dgvMovies.SelectedRows[0].Cells[3].Value.ToString();
            string Year = dgvMovies.SelectedRows[0].Cells[2].Value.ToString();
            int ID = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells[0].Value);

            Form editMovie = new FormEditMovie(Title, Year, Genre, Rating, ID);
            editMovie.ShowDialog();
            LoadTables();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string fN;
            string lN;
            string address;
            string phone;

            using (var addCust = new FormAddCustomer())
            {
                if (addCust.ShowDialog() == DialogResult.OK)
                {
                    fN = addCust.fN;
                    lN = addCust.lN;
                    address = addCust.address;
                    phone = addCust.phone;
                }
            }
        }
        private void updateDatabase()
        {
            var myData = new Data();
            foreach (DataGridViewRow row in dgvMovies.Rows)
            {
                try
                {
                    string title = row.Cells[1].Value.ToString();
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    var myMovie = myData.GetJson(title);
                    if (myMovie.Title != null)
                    {
                        myData.EditMovie(myMovie.Title, myMovie.Plot, myMovie.Year, myMovie.Rated, myMovie.Genre, id);
                        LoadTables();
                    }

                }
                catch (Exception)
                {

                    //throw;
                }

            }
            MessageBox.Show("Database has been updated");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateDatabase();
        }

        //private void btnNewRental_Click(object sender, EventArgs e)
        //{
        //    var myData = new Data();
        //    myData.addRental(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        //    LoadTables();
        //}

        private void btnReturn_Click(object sender, EventArgs e)
        {
            var myData = new Data();
            int ID = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells[0].Value);
            myData.ReturnRental(ID);
            LoadTables();
        }

        //Placeholder for a logout button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
