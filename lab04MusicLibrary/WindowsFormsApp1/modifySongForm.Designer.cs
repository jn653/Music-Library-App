
namespace WindowsFormsApp1
{
    partial class modifySongForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtModifySong = new System.Windows.Forms.TextBox();
            this.btnSubmitModification = new System.Windows.Forms.Button();
            this.txtSongArtistChanged = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type the name of the song you want to modify:";
            // 
            // txtModifySong
            // 
            this.txtModifySong.Location = new System.Drawing.Point(34, 88);
            this.txtModifySong.Name = "txtModifySong";
            this.txtModifySong.Size = new System.Drawing.Size(190, 20);
            this.txtModifySong.TabIndex = 1;
            // 
            // btnSubmitModification
            // 
            this.btnSubmitModification.Location = new System.Drawing.Point(660, 88);
            this.btnSubmitModification.Name = "btnSubmitModification";
            this.btnSubmitModification.Size = new System.Drawing.Size(95, 36);
            this.btnSubmitModification.TabIndex = 2;
            this.btnSubmitModification.Text = "Submit Modification";
            this.btnSubmitModification.UseVisualStyleBackColor = true;
            this.btnSubmitModification.Click += new System.EventHandler(this.btnSubmitModification_Click);
            // 
            // txtSongArtistChanged
            // 
            this.txtSongArtistChanged.Location = new System.Drawing.Point(377, 88);
            this.txtSongArtistChanged.Name = "txtSongArtistChanged";
            this.txtSongArtistChanged.Size = new System.Drawing.Size(204, 20);
            this.txtSongArtistChanged.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Type what you want the artist of the song to be:\r\n";
            // 
            // modifySongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 149);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSongArtistChanged);
            this.Controls.Add(this.btnSubmitModification);
            this.Controls.Add(this.txtModifySong);
            this.Controls.Add(this.label1);
            this.Name = "modifySongForm";
            this.Text = "modifySongForm";
            this.Load += new System.EventHandler(this.modifySongForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModifySong;
        private System.Windows.Forms.Button btnSubmitModification;
        private System.Windows.Forms.TextBox txtSongArtistChanged;
        private System.Windows.Forms.Label label2;
    }
}