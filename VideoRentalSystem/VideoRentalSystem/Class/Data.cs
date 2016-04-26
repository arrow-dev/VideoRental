using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace VideoRentalSystem.Class
{
    class Data
    {
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da;
        private String ConnectionString;


        //Constructor initializes connection string to database
        public Data()
        {
            ConnectionString = @"Data Source=DESKTOP-OLS6GQ1\SQLEXPRESS;Initial Catalog=VBMoviesFullData;Integrated Security=True";
            Connection.ConnectionString = ConnectionString;
            Command.Connection = Connection;
        }

        //This method returns a data table. Used for populating datagrid views.
        public DataTable GetTable(string columns, string tablename)
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("SELECT " + columns + " FROM " + tablename, Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        //This method queries the omdb api with a movie title and deserializes the resulting json string to a C# object.
        public Movie GetJson(string title)
        {
            Movie movie;
            using (var client = new WebClient())
            {
                var Json = client.DownloadString("http://www.omdbapi.com/?t=" + title.Trim() + "&y=&plot=long&r=json");
                movie = JsonConvert.DeserializeObject<Movie>(Json);
            }
            return movie;
        }

        //Adds a movie to the database via stored proceedure.
        public void AddMovie(string p1, string p2, string p3, string p4, string p5)
        {
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "AddMovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", p1);
                cmd.Parameters.AddWithValue("@Plot", p2);
                cmd.Parameters.AddWithValue("@Year", p3);
                cmd.Parameters.AddWithValue("@Rating", p4);
                cmd.Parameters.AddWithValue("@Genre", p5);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

            }
        }

        //Adds a customer to the database via stored proceedure.
        public void AddCustomer(string p1, string p2, string p3, string p4)
        {
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "AddCustomer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", p1);
                cmd.Parameters.AddWithValue("@LastName", p2);
                cmd.Parameters.AddWithValue("@Address", p3);
                cmd.Parameters.AddWithValue("@Phone", p4);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

            }
        }

        //Updates a movie in database via stored proceedure.
        public void EditMovie(string p1, string p2, string p3, string p4, string p5, int ID)
        {
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "EditMovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", p1);
                cmd.Parameters.AddWithValue("@Plot", p2);
                cmd.Parameters.AddWithValue("@Year", p3);
                cmd.Parameters.AddWithValue("@Rating", p4);
                cmd.Parameters.AddWithValue("@Genre", p5);
                cmd.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

            }
        }

        //Updates a customer in database via stored proceedure.
        public void EditCust(string p1, string p2, string p3, string p4, int ID)
        {
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "EditCustomer";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FirstName", p1);
                cmd.Parameters.AddWithValue("@LastName", p2);
                cmd.Parameters.AddWithValue("@Address", p3);
                cmd.Parameters.AddWithValue("@Phone", p4);
                cmd.Parameters.AddWithValue("@ID", ID);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

            }
        }

        //Deletes a record from the database via direct sql command.
        public void DeleteRecord(string table, int index)
        {
            string pk = "";
            string sql;
            switch (table)
            {
                case "Movies":
                    {
                        pk = "MovieID";
                        break;
                    }
                case "Customer":
                    {
                        pk = "CustID";
                        break;
                    }
                case "RentedMovies":
                    {
                        pk = "RMID";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            sql = "DELETE FROM " + table + " WHERE " + pk + " = " + index;
            Command.CommandText = sql;
            Connection.Open();
            Command.ExecuteNonQuery();
            Connection.Close();
        }

        //Adds a rental to the database via stored proceedure.
        public void addRental(int mID, int cID)
        {
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "AddRental";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MovieID", mID);
                cmd.Parameters.AddWithValue("@CustomerID", cID);
                cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();

            }
        }

        //Updates a rental return date via stored proceedure.
        public void ReturnRental(int id)
        {
            using (SqlCommand cmd = Connection.CreateCommand())
            {
                cmd.CommandText = "ReturnMovie";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@DATE", DateTime.Now);
                Connection.Open();
                cmd.ExecuteNonQuery();
                Connection.Close();
            }
        }
    }
}

