using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class deleteSongForm : Form
    {
        public deleteSongForm()
        {
            InitializeComponent();
        }

        private void btnDeleteSong_Click(object sender, EventArgs e)
        {
            string songDeletion = txtDeleteSong.Text;
            MusicCollection.deleteSong(songDeletion);
        }

        private void deleteSongForm_Load(object sender, EventArgs e)
        {

        }
    }
}
