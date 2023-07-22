using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class MusicCollection
    {
        


        public static string addSong(string songGenre, string artistBand, string albumName, string songDescription, int releaseYear, int songDuration, string albumImgUrl, string songName)
        {
            
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
            string strSQL = "INSERT INTO Music (AlbumName, AlbumDescription, ArtistBand, Songgenre, SongDuration, AlbumImage, AlbumReleaseYear, SongName) " +
                     "VALUES ('" + albumName + "','" + songDescription + "','" + artistBand + "','" + songGenre + "','" + songDuration + "," + albumImgUrl + "','" + releaseYear + "," + songName + "')";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);
           

            try
            {
                myConnection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("error" + ex);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("erorr" + ex);
            }

            finally
            {
                myConnection.Close();
            }
            return "worked";

            //try 
            //{
            //    OleDbConnection myConnection = new OleDbConnection();
            //    myConnection.ConnectionString = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
            //    myConnection.Open();
            //    OleDbCommand command = new OleDbCommand();
            //    command.Connection = myConnection;
            //    command.CommandText = "insert into Music (Album Name, Album Description, Artist/Band, Song genre, Song Duration, Album Image, Album Release Year, Song Name) " +
            //          "VALUES (' " + albumName + " ',' " + songDescription + " ',' " + artistBand + " ',' " + songGenre + " ',' " + songDuration + " ',' " + albumImgUrl + " ',' " + releaseYear + " ',' " + songName + " ')";
            //    command.ExecuteNonQuery();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error" + ex);
            //}
            //return "it worked";
        }

        public static string modifySong(string songName, string modifiedSongArtist)
        {

            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
            string strSQL = "UPDATE Music SET ArtistBand ='" + modifiedSongArtist + "'" +
                     "WHERE Song Name='" + songName + "'";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand updateCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();
                updateCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("error" + ex);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("erorr" + ex);
            }

            finally
            {
                myConnection.Close();
            }

            return "it worked";
        }

        public static string deleteSong(string songName)
        {
            string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;";
            string strSQL = "DELETE FROM Music WHERE SongName ='" + songName + "'";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand deleteCommand = new OleDbCommand(strSQL, myConnection);

            try
            {
                myConnection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("error" + ex);
            }
            catch (SystemException ex)
            {
                MessageBox.Show("erorr" + ex);
            }

            finally
            {
                myConnection.Close();
            }
            return "it worked";
        }
    }
}
