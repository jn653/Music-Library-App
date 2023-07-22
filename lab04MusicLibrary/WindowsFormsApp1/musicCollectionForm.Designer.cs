
namespace WindowsFormsApp1
{
    partial class musicCollectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgMusic = new System.Windows.Forms.DataGridView();
            this.btnShowMusicCollection = new System.Windows.Forms.Button();
            this.btnSearchGenre = new System.Windows.Forms.Button();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddnewSong = new System.Windows.Forms.Button();
            this.btnDeleteSong = new System.Windows.Forms.Button();
            this.btnSearchartistBand = new System.Windows.Forms.Button();
            this.txtSearchArtistorBand = new System.Windows.Forms.TextBox();
            this.btnModifySong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMusic
            // 
            this.dgMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMusic.Location = new System.Drawing.Point(0, -1);
            this.dgMusic.Name = "dgMusic";
            this.dgMusic.Size = new System.Drawing.Size(879, 250);
            this.dgMusic.TabIndex = 0;
            this.dgMusic.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMusic_CellContentClick);
            // 
            // btnShowMusicCollection
            // 
            this.btnShowMusicCollection.Location = new System.Drawing.Point(0, 257);
            this.btnShowMusicCollection.Name = "btnShowMusicCollection";
            this.btnShowMusicCollection.Size = new System.Drawing.Size(179, 41);
            this.btnShowMusicCollection.TabIndex = 1;
            this.btnShowMusicCollection.Text = "Show music collection";
            this.btnShowMusicCollection.UseVisualStyleBackColor = true;
            this.btnShowMusicCollection.Click += new System.EventHandler(this.btnMusicCollection_Click);
            // 
            // btnSearchGenre
            // 
            this.btnSearchGenre.Location = new System.Drawing.Point(181, 367);
            this.btnSearchGenre.Name = "btnSearchGenre";
            this.btnSearchGenre.Size = new System.Drawing.Size(85, 36);
            this.btnSearchGenre.TabIndex = 2;
            this.btnSearchGenre.Text = "Search song by genre";
            this.btnSearchGenre.UseVisualStyleBackColor = true;
            this.btnSearchGenre.Click += new System.EventHandler(this.btnSearchGenre_Click);
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            "Rap",
            "Latin",
            "Jazz",
            "Country",
            "Rock",
            "Classical",
            "Soul",
            "Techno",
            "Hip-Hop",
            "K-pop",
            "Pop"});
            this.comboBoxGenre.Location = new System.Drawing.Point(0, 367);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(150, 21);
            this.comboBoxGenre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a genre ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Select an artist or band";
            // 
            // btnAddnewSong
            // 
            this.btnAddnewSong.Location = new System.Drawing.Point(219, 258);
            this.btnAddnewSong.Name = "btnAddnewSong";
            this.btnAddnewSong.Size = new System.Drawing.Size(179, 40);
            this.btnAddnewSong.TabIndex = 7;
            this.btnAddnewSong.Text = "Add a new Song";
            this.btnAddnewSong.UseVisualStyleBackColor = true;
            this.btnAddnewSong.Click += new System.EventHandler(this.btnAddnewSong_Click);
            // 
            // btnDeleteSong
            // 
            this.btnDeleteSong.Location = new System.Drawing.Point(476, 258);
            this.btnDeleteSong.Name = "btnDeleteSong";
            this.btnDeleteSong.Size = new System.Drawing.Size(179, 40);
            this.btnDeleteSong.TabIndex = 8;
            this.btnDeleteSong.Text = "Delete a Song";
            this.btnDeleteSong.UseVisualStyleBackColor = true;
            this.btnDeleteSong.Click += new System.EventHandler(this.btnDeleteSong_Click);
            // 
            // btnSearchartistBand
            // 
            this.btnSearchartistBand.Location = new System.Drawing.Point(637, 367);
            this.btnSearchartistBand.Name = "btnSearchartistBand";
            this.btnSearchartistBand.Size = new System.Drawing.Size(90, 47);
            this.btnSearchartistBand.TabIndex = 10;
            this.btnSearchartistBand.Text = "Search song by artist or band";
            this.btnSearchartistBand.UseVisualStyleBackColor = true;
            this.btnSearchartistBand.Click += new System.EventHandler(this.btnSearchartistBand_Click);
            // 
            // txtSearchArtistorBand
            // 
            this.txtSearchArtistorBand.Location = new System.Drawing.Point(438, 367);
            this.txtSearchArtistorBand.Name = "txtSearchArtistorBand";
            this.txtSearchArtistorBand.Size = new System.Drawing.Size(147, 20);
            this.txtSearchArtistorBand.TabIndex = 11;
            // 
            // btnModifySong
            // 
            this.btnModifySong.Location = new System.Drawing.Point(702, 258);
            this.btnModifySong.Name = "btnModifySong";
            this.btnModifySong.Size = new System.Drawing.Size(142, 40);
            this.btnModifySong.TabIndex = 12;
            this.btnModifySong.Text = "Modify a Song";
            this.btnModifySong.UseVisualStyleBackColor = true;
            this.btnModifySong.Click += new System.EventHandler(this.btnModifySong_Click);
            // 
            // musicCollectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.btnModifySong);
            this.Controls.Add(this.txtSearchArtistorBand);
            this.Controls.Add(this.btnSearchartistBand);
            this.Controls.Add(this.btnDeleteSong);
            this.Controls.Add(this.btnAddnewSong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.btnSearchGenre);
            this.Controls.Add(this.btnShowMusicCollection);
            this.Controls.Add(this.dgMusic);
            this.Name = "musicCollectionForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.musicCollectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMusic;
        private System.Windows.Forms.Button btnShowMusicCollection;
        private System.Windows.Forms.Button btnSearchGenre;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddnewSong;
        private System.Windows.Forms.Button btnDeleteSong;
        private System.Windows.Forms.Button btnSearchartistBand;
        private System.Windows.Forms.TextBox txtSearchArtistorBand;
        private System.Windows.Forms.Button btnModifySong;
    }
}

