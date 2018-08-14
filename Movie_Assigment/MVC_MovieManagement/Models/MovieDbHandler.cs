using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_MovieManagement.Models;

namespace MVC_MovieManagement.Models
{
    public class MovieDbHandler : Controller
    {
        private SqlConnection con;
        private void connection()
        {
            string constring = ConfigurationManager.ConnectionStrings["DB"].ToString();
            con = new SqlConnection(constring);
        }

        // **************** ADD NEW Movie *********************
        public bool AddMovie(Movie Movie)
        {
            connection();
            SqlCommand cmd = new SqlCommand("sp_InsertMovie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MovieName", Movie.MovieName);
            cmd.Parameters.AddWithValue("@MovieDetails", Movie.MovieDetails);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }

        // **********GetMovie ********************
        public List<Movie> GetMovie()
        {
            connection();
            List<Movie> MovieList = new List<Movie>();

            SqlCommand cmd = new SqlCommand("sp_GetMovieDetails", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            sd.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                MovieList.Add(
                    new Movie
                    {
                        MovieId = Convert.ToInt32(dr["MovieId"]),
                        MovieName = Convert.ToString(dr["MovieName"]),
                        MovieDetails = Convert.ToString(dr["MovieDetails"]),
               
                    });
            }
            return MovieList;
        }

        // ***************** UPDATE Movie *********************
        public void UpdateMovie(Movie Movie)
        {
            connection();
            SqlCommand cmd = new SqlCommand("sp_UpdatMovie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MovieId", Movie.MovieId);
            cmd.Parameters.AddWithValue("@MovieName", Movie.MovieName);
            cmd.Parameters.AddWithValue("@MovieDetails", Movie.MovieDetails);

            con.Open();
            cmd.ExecuteNonQuery();
           // int i = cmd.ExecuteNonQuery();
            con.Close();

            //if (i >= 1)
            //    return true;
            //else
            //    return false;
        }

        // ********************** DELETE Movie *******************
        public bool DeleteMovie(int id)
        {
            connection();
            SqlCommand cmd = new SqlCommand("sp_DeleteMovie", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MovieId", id);

            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();

            if (i >= 1)
                return true;
            else
                return false;
        }
    }
}
