using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addSongForm : Form
    {
        string strSQL;
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        public string songGenre;
        Song addmusic = new Song();




        public addSongForm()
        {
            InitializeComponent();
        }

        private void addSongForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAddSongtoDatagrid_Click(object sender, EventArgs e)
        {

            //myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb;");
            //strSQL = "INSERT INTO Music (Song genre)" + "VALUES ('" + comboBoxSongGenre.Text + "')";
            //OleDbCommand insertCommand = new OleDbCommand(strSQL, myConnection);
            //try
            //{
            //    myConnection.Open();
            //    insertCommand.ExecuteNonQuery();
            //}
            //catch (OleDbException ex)
            // //...
            // catch (SystemException ex)
            //// ...
            // finally
            //{
            //    myConnection.Close();
            //}

            //addmusic.SongGenre = comboBoxSongGenre.Text;
            //addmusic.ArtistBand = txtArtistBand.Text;
            //addmusic.AlbumName = txtAlbumName.Text;
            //addmusic.songDescription = txtAlbumDescription.Text;
            //addmusic.ReleaseYear = txtSongYear.Text;
            //addmusic.SongDuration = txtSongDuration.Text;
            //addmusic.albumImgUrl = txtImageUrl.Text;
            //addmusic.songName = txtSongName.Text;
            MusicCollection.addSong(comboBoxSongGenre.Text, txtArtistBand.Text, txtAlbumName.Text, txtAlbumDescription.Text, int.Parse(txtSongYear.Text), int.Parse(txtSongDuration.Text), txtImageUrl.Text, txtSongName.Text);
            this.Hide();
        }

        
    }
}
