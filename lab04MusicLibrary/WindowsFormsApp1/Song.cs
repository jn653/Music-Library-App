using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class Song
    {
        public string songGenre;
        public string artistBand;
        public string albumName;
        public string songDescription;
        public int releaseYear;
        public int songDuration;
        public string albumImgUrl;
        public string songName;

        public Song()
        {

        }

        public Song(string songGenre, string artistBand, string albumName, string songDescription, int releaseYear, int songDuration, string albumImgUrl, string songName)
        {
            this.songGenre = songGenre;
            this.artistBand = artistBand;
            this.albumName = albumName;
            this.songDescription = songDescription;
            this.releaseYear = releaseYear;
            this.songDuration = songDuration;
            this.albumImgUrl = albumImgUrl;
            this.songName = songName;
        }


        public string SongGenre
        {
            get
            {
                return songGenre;
            }
            set
            {
                songGenre = value;
            }
        }

        public string ArtistBand
        {
            get
            {
                return artistBand;
            }
            set
            {
                artistBand = value;
            }
        }

        public string AlbumName
        {
            get
            {
                return albumName;
            }
            set
            {
                albumName = value;
            }
        }

        public string SongDescription
        {
            get
            {
                return songDescription;
            }
            set
            {
                songDescription = value;
            }
        }

        public int ReleaseYear
        {
            get
            {
                return releaseYear;
            }
            set
            {
                releaseYear = value;
            }
        }

        public int SongDuration
        {
            get
            {
                return songDuration;
            }
            set
            {
                songDuration = value;
            }
        }

        public String AlbumImageUrl
        {
            get
            {
                return albumImgUrl;
            }
            set
            {
                albumImgUrl = value;
            }
        }

        public String SongName
        {
            get
            {
                return songName;
            }
            set
            {
                songName = value;
            }
        }

    }
}

