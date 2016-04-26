using System;
using System.Windows.Forms;
using VideoRentalSystem.Class;
using VideoStore;

namespace VideoRentalSystem.Forms
{
    public partial class FormDataView : FormTemplate
    {
        private Data myData;
        private int selectedCust; //Keeps track of which customer has been selected
        private int selectedMovie; //Keeps track of which movie has been selected
        private bool allRentals = true; //Used for toggling the view in rentals.
        private Movie myMovie;

        public FormDataView()
        {
            InitializeComponent();
        }

        //On form load initialize the data class after populating datagrid views.
        private void FormDataView_Load(object sender, EventArgs e)
        {
            LoadTables();
            myData = new Data();
        }

        //Populates datagrid views, used at start up and to refresh after changes have been made to data.
        public void LoadTables()
        {
            var myData = new Data();
            dgvMovies.DataSource = myData.GetTable("MovieID, title, year, rating, genre, plot", "movies");
            dgvUsers.DataSource = myData.GetTable("*", "customer");
            dgvRentals.DataSource = myData.GetTable("*", "RentalsFriendly");
        }

        //Selects a movie and displays data for that movie.
        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String myTitle = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            myMovie = myData.GetJson(myTitle);
            selectedMovie = Convert.ToInt32(dgvMovies.Rows[e.RowIndex].Cells[0].Value);
            lblSMovie.Text = myTitle;
            try
            {
                pbxPoster.LoadAsync(myMovie.Poster);
                lblTitle.Text = myMovie.Title;
                lblPlot.Text = myMovie.Plot;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong! " + ex.Message);
            }
        }

        //Deletes a selected movie from the database.
        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            try
            {
                myData.DeleteRecord("Movies", Convert.ToInt32(dgvMovies.SelectedRows[0].Cells[0].Value));
                LoadTables();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a movie to delete!");
            }
        }

        //Opens add movie form.
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            Form addMovie = new FormAddMovie();
            if (addMovie.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Movie Added");
            }
            
            
            LoadTables();
        }

        //Selected movie info is sent to the edit movie form where the user can edit the data and update the database.
        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            string Title = dgvMovies.SelectedRows[0].Cells[1].Value.ToString();
            string Genre = dgvMovies.SelectedRows[0].Cells[4].Value.ToString();
            string Rating = dgvMovies.SelectedRows[0].Cells[3].Value.ToString();
            string Year = dgvMovies.SelectedRows[0].Cells[2].Value.ToString();
            string Plot = dgvMovies.SelectedRows[0].Cells[5].Value.ToString();
            int ID = Convert.ToInt32(dgvMovies.SelectedRows[0].Cells[0].Value);

            Form editMovie = new FormEditMovie(Title, Year, Genre, Rating, Plot, ID);
            editMovie.ShowDialog();
            LoadTables();
        }

        //Adds a user using a seperate form for data entry.
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
                    
                    myData.AddCustomer(fN, lN, address, phone);
                    MessageBox.Show("Customer Added");
                    LoadTables();
                }
            }
        }

        //Removes selected customer from database.
        private void btnRemoveCust_Click(object sender, EventArgs e)
        {
            try
            {
                myData.DeleteRecord("Customer", Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value));
                MessageBox.Show("Customer Deleted");
                LoadTables();
            }
            catch (Exception)
            {
                MessageBox.Show("Make sure you have selected a customer!");
            }
        }

        //This method goes through every movie in the database and syncs the data with the OMDB database.
        private void updateDatabase()
        {
            foreach (DataGridViewRow row in dgvMovies.Rows)
            {
                try
                {
                    string title = row.Cells[1].Value.ToString();
                    int id = Convert.ToInt32(row.Cells[0].Value);
                    myMovie = myData.GetJson(title);
                    if (myMovie.Title != null)
                    {
                        myData.EditMovie(myMovie.Title, myMovie.Plot, myMovie.Year, myMovie.Rated, myMovie.Genre, id);
                        LoadTables();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            MessageBox.Show("Database has been updated");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateDatabase();
        }

        //Gets selected rental id and sends it to the ReturnRental method.
        private void btnReturn_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells[0].Value);
            myData.ReturnRental(ID);
            LoadTables();
        }

        //Placeholder for a logout button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //Edit a customer using a separate form.
        private void btnEditCust_Click(object sender, EventArgs e)
        {
            string fName = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            string lName = dgvUsers.SelectedRows[0].Cells[2].Value.ToString();
            string addr = dgvUsers.SelectedRows[0].Cells[3].Value.ToString();
            string phone = dgvUsers.SelectedRows[0].Cells[4].Value.ToString();
            int ID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
            using (var editCust = new FormEditCust(fName, lName, addr, phone, ID))
            {
                if (editCust.ShowDialog() == DialogResult.OK)
                {
                    fName = editCust.fN;
                    lName = editCust.lN;
                    addr = editCust.address;
                    phone = editCust.phone;
                    
                    myData.EditCust(fName, lName, addr, phone, ID);
                    MessageBox.Show("Customer Updated");
                    LoadTables();
                }
            }
            LoadTables();
        }

        //Adds a new rental using selected movie, customer and a the current system datetime and displays a message with the price to charge the customer.
        private void btnNewRental_Click(object sender, EventArgs e)
        {
            if (lblSCust.Text != "none" && lblSMovie.Text != "none")
            {
                try
                {
                    int price = 5;
                    DateTime date = Convert.ToDateTime("1/1/"+ myMovie.Year);
                    myData.addRental(selectedMovie, selectedCust);
                    if (date.Year < (DateTime.Now.Year - 5))
                    {
                        price = 2;
                    }
                    MessageBox.Show("New rental added, price is $" + price);
                    LoadTables();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong, make sure you have selected a movie and a customer.");
                }
            }
            else
            {
                MessageBox.Show("Something went wrong, make sure you have selected a movie and a customer.");
            }
        }

        //Toggles the datasource for the datagrid view.
        private void btnViewToggle_Click(object sender, EventArgs e)
        {
            if (allRentals)
            {
                dgvRentals.DataSource = myData.GetTable("*", "RentalsFriendlyNotReturned");
                btnViewToggle.Text = "Show all Rentals";
                allRentals = false;
            }
            else
            {
                LoadTables();
                btnViewToggle.Text = "Show unreturned Rentals";
                allRentals = true;
            }
        }

        //Updates labels on rental page when a user is selected.
        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var f = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            var l = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedCust = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            lblSCust.Text = string.Format("{0} {1}", f, l);
        }

        //Opens stat form passing in a datatable filled from a view.
        private void btnTopMovie_Click(object sender, EventArgs e)
        {
            var StatForm = new FormStats(myData.GetTable("*", "RentalsPerMovie"));
            StatForm.ShowDialog();
        }

        //Opens stat form passing in a datatable filled from a view.
        private void btnTopCust_Click(object sender, EventArgs e)
        {
            var StatForm = new FormStats(myData.GetTable("*", "RentalsPerCust"));
            StatForm.ShowDialog();
        }
    }
}
