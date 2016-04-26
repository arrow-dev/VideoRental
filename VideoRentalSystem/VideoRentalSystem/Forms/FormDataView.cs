﻿using System;
using System.Windows.Forms;
using VideoRentalSystem.Class;
using VideoStore;

namespace VideoRentalSystem.Forms
{
    public partial class FormDataView : FormTemplate
    {
        private Data myData;
        private int selectedCust;
        private int selectedMovie;
        private bool allRentals = true;
        private Movie myMovie;

        public FormDataView()
        {
            InitializeComponent();
        }

        private void FormDataView_Load(object sender, EventArgs e)
        {
            LoadTables();
            myData = new Data();
        }

        public void LoadTables()
        {
            var myData = new Data();
            dgvMovies.DataSource = myData.GetTable("MovieID, title, year, rating, genre, plot", "movies");
            dgvUsers.DataSource = myData.GetTable("*", "customer");
            dgvRentals.DataSource = myData.GetTable("*", "RentalsFriendly");
        }

        private void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //var myData = new Data();
            String myTitle = dgvMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            myMovie = myData.GetJson(myTitle);
            selectedMovie = Convert.ToInt32(dgvMovies.Rows[e.RowIndex].Cells[0].Value);
            lblSMovie.Text = myTitle;
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
            //var myData = new Data();
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
            if (addMovie.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Movie Added");
            }
            
            
            LoadTables();
        }

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

                    //var myData = new Data();
                    myData.AddCustomer(fN, lN, address, phone);
                    MessageBox.Show("Customer Added");
                    LoadTables();
                }
            }
        }

        private void btnRemoveCust_Click(object sender, EventArgs e)
        {
            //var myData = new Data();
            try
            {
                myData.DeleteRecord("Customer", Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value));
                MessageBox.Show("Customer Deleted");
                LoadTables();
            }
            catch (Exception)
            {

            }
        }

        private void updateDatabase()
        {
            //var myData = new Data();
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
                catch (Exception)
                {

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
            //var myData = new Data();
            int ID = Convert.ToInt32(dgvRentals.SelectedRows[0].Cells[0].Value);
            myData.ReturnRental(ID);
            LoadTables();
        }

        //Placeholder for a logout button
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

                    //var myData = new Data();
                    myData.EditCust(fName, lName, addr, phone, ID);
                    MessageBox.Show("Customer Updated");
                    LoadTables();
                }
            }

            ;
            LoadTables();
        }

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

        private void btnReturn_Click_1(object sender, EventArgs e)
        {
            myData.ReturnRental(Convert.ToInt32(dgvRentals.SelectedRows[0].Cells[0].Value));
            LoadTables();
        }

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

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string f = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            string l = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            selectedCust = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
            lblSCust.Text = string.Format("{0} {1}", f, l)
            ;
        }

        private void btnTopMovie_Click(object sender, EventArgs e)
        {
            var StatForm = new FormStats(myData.GetTable("*", "RentalsPerMovie"));
            StatForm.ShowDialog();
        }

        private void btnTopCust_Click(object sender, EventArgs e)
        {
            var StatForm = new FormStats(myData.GetTable("*", "RentalsPerCust"));
            StatForm.ShowDialog();
        }
    }
}
