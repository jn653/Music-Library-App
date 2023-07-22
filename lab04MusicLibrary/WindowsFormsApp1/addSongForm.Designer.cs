
namespace WindowsFormsApp1
{
    partial class addSongForm
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
            this.comboBoxSongGenre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtArtistBand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAlbumDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSongYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSongDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImageUrl = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddSongtoDatagrid = new System.Windows.Forms.Button();
            this.txtSongName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxSongGenre
            // 
            this.comboBoxSongGenre.FormattingEnabled = true;
            this.comboBoxSongGenre.Items.AddRange(new object[] {
            "rap",
            "pop",
            "Hip-hop",
            "jazz",
            "classical",
            "country",
            "Latin"});
            this.comboBoxSongGenre.Location = new System.Drawing.Point(27, 70);
            this.comboBoxSongGenre.Name = "comboBoxSongGenre";
            this.comboBoxSongGenre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSongGenre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick Song genre:";
            // 
            // txtArtistBand
            // 
            this.txtArtistBand.Location = new System.Drawing.Point(215, 71);
            this.txtArtistBand.Name = "txtArtistBand";
            this.txtArtistBand.Size = new System.Drawing.Size(110, 20);
            this.txtArtistBand.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "type in artist/band";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(386, 70);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(105, 20);
            this.txtAlbumName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(386, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Type in album name:";
            // 
            // txtAlbumDescription
            // 
            this.txtAlbumDescription.Location = new System.Drawing.Point(553, 70);
            this.txtAlbumDescription.Name = "txtAlbumDescription";
            this.txtAlbumDescription.Size = new System.Drawing.Size(130, 20);
            this.txtAlbumDescription.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type in song description:";
            // 
            // txtSongYear
            // 
            this.txtSongYear.Location = new System.Drawing.Point(30, 189);
            this.txtSongYear.Name = "txtSongYear";
            this.txtSongYear.Size = new System.Drawing.Size(177, 20);
            this.txtSongYear.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type in the year the song came out:";
            // 
            // txtSongDuration
            // 
            this.txtSongDuration.Location = new System.Drawing.Point(303, 189);
            this.txtSongDuration.Name = "txtSongDuration";
            this.txtSongDuration.Size = new System.Drawing.Size(100, 20);
            this.txtSongDuration.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "type in song duration:";
            // 
            // txtImageUrl
            // 
            this.txtImageUrl.Location = new System.Drawing.Point(607, 189);
            this.txtImageUrl.Name = "txtImageUrl";
            this.txtImageUrl.Size = new System.Drawing.Size(144, 20);
            this.txtImageUrl.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(604, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type in Album Image Url:";
            // 
            // btnAddSongtoDatagrid
            // 
            this.btnAddSongtoDatagrid.Location = new System.Drawing.Point(340, 334);
            this.btnAddSongtoDatagrid.Name = "btnAddSongtoDatagrid";
            this.btnAddSongtoDatagrid.Size = new System.Drawing.Size(113, 35);
            this.btnAddSongtoDatagrid.TabIndex = 14;
            this.btnAddSongtoDatagrid.Text = "Add Song to Collection";
            this.btnAddSongtoDatagrid.UseVisualStyleBackColor = true;
            this.btnAddSongtoDatagrid.Click += new System.EventHandler(this.btnAddSongtoDatagrid_Click);
            // 
            // txtSongName
            // 
            this.txtSongName.Location = new System.Drawing.Point(450, 188);
            this.txtSongName.Name = "txtSongName";
            this.txtSongName.Size = new System.Drawing.Size(100, 20);
            this.txtSongName.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Type Song Name:";
            // 
            // addSongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSongName);
            this.Controls.Add(this.btnAddSongtoDatagrid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtImageUrl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSongDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSongYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAlbumDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAlbumName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArtistBand);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSongGenre);
            this.Name = "addSongForm";
            this.Text = "addSongForm";
            this.Load += new System.EventHandler(this.addSongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSongGenre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtArtistBand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAlbumDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSongYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSongDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtImageUrl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddSongtoDatagrid;
        private System.Windows.Forms.TextBox txtSongName;
        private System.Windows.Forms.Label label8;
    }
}