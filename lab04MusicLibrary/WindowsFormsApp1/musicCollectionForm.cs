using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class musicCollectionForm : Form
    {
        List<Song> MusicList = new List<Song>();
        string strSQL;
        DataSet songDataSet, GenreDataSet;
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataTable MusicTable;

        //public string songGenre;
        //public string artistBand;
        //public string albumName;
        //public string songDescription;
        //public string releaseYear;
        //public string songDuration;
        //public string albumImgUrl;

        //public void SetStrings(string genre, string artist, string album, string description, string year, string duration, string image)
        //{
        //    songGenre = genre;
        //    artistBand = artist;
        //    albumName = album;
        //    songDescription = description;
        //    releaseYear = year;
        //    songDuration = duration;
        //    albumImgUrl = image;

        //}

        public musicCollectionForm()
        {
            InitializeComponent();
            
        }

        private void btnMusicCollection_Click(object sender, EventArgs e)
        {
            //make a list of music that gets the information from the database rows and then add that music list to my datagrid
            foreach (DataRow record in MusicTable.Rows)
            {
                Song music = new Song();
                music.albumName = record["AlbumName"].ToString();
                music.songDescription = record["AlbumDescription"].ToString();
                music.artistBand = record["ArtistBand"].ToString();
                music.songGenre = record["Songgenre"].ToString();
                music.songDuration = int.Parse(record["SongDuration"].ToString());
               // music.AlbumImageUrl = record["Album Image"].ToString();
                music.releaseYear = int.Parse(record["AlbumReleaseYear"].ToString());
                music.songName = record["SongName"].ToString();

                MusicList.Add(music);
                
            }

            // put the datasource into the datagrid view to display music list
            dgMusic.DataSource = MusicList;
        }

        private void musicCollectionForm_Load(object sender, EventArgs e) 
        {
            // connecting to my database
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;");
            strSQL = "SELECT * FROM Music";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            songDataSet = new DataSet("MusicsTable");
            myDataAdapter.Fill(songDataSet, "MusicsTable");

            // add my table value to the data grid view
            MusicTable = songDataSet.Tables["MusicsTable"];
            dgMusic.DataSource = MusicTable;


           

        }

        private void btnAddnewSong_Click(object sender, EventArgs e)
        {
            addSongForm newForm = new addSongForm();
            newForm.ShowDialog();
            // songGenre = newForm.sendGenre();
            // //connect to my database and get the songs that have the song genre the same as the value of the combobox
            // myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;");
            // strSQL = "INSERT INTO Music (Song genre)" + "VALUES ('" + songGenre + "')" ;
            // OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);
            // try
            // {
            //     myConnection.Open();
            //     insertCommand.ExecuteNonQuery();
            // }
            // catch(OleDbException ex)
            // //...
            // catch(SystemException ex)
            //// ...
            // finally
            // {
            //     myConnection.Close();
            // }



        }

        private void btnSearchGenre_Click(object sender, EventArgs e)
        {
            // make a new list to store found items
            List<Song> genreMatchedResult = new List<Song>();

           //search my music list to find the song genre that matches combo box
            foreach (Song music in MusicList)
            {
                if (music.songGenre.CompareTo(comboBoxGenre.SelectedItem) == 0)
                    genreMatchedResult.Add(music);
            }

            // show results in datagrid view
            dgMusic.DataSource = genreMatchedResult;

        }

        private void btnSearchartistBand_Click(object sender, EventArgs e)
        {
            // make a new list to store found items
            List<Song> artistMatchedResult = new List<Song>();

            //search my music list to find the song genre that matches combo box
            foreach (Song music in MusicList)
            {
                if (music.artistBand.CompareTo(txtSearchArtistorBand.Text) == 0)
                    artistMatchedResult.Add(music);
            }

            // show results in datagrid view
            dgMusic.DataSource = artistMatchedResult;

        }

        private void btnModifySong_Click(object sender, EventArgs e)
        {
            modifySongForm newForm = new modifySongForm();
            newForm.ShowDialog();

        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            deleteSongForm newForm = new deleteSongForm();
            newForm.ShowDialog();
        }

        private void dgMusic_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("");
        }
    }
}
