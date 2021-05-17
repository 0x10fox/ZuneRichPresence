
namespace ZuneRichPresence
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nplabel = new System.Windows.Forms.Label();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.albumNameLabel = new System.Windows.Forms.Label();
            this.artistNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nplabel
            // 
            this.nplabel.AutoSize = true;
            this.nplabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nplabel.Font = new System.Drawing.Font("Segoe UI Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nplabel.ForeColor = System.Drawing.Color.White;
            this.nplabel.Location = new System.Drawing.Point(501, 53);
            this.nplabel.Name = "nplabel";
            this.nplabel.Size = new System.Drawing.Size(386, 89);
            this.nplabel.TabIndex = 0;
            this.nplabel.Text = "now playing";
            this.nplabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.songNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.songNameLabel.ForeColor = System.Drawing.Color.White;
            this.songNameLabel.Location = new System.Drawing.Point(501, 202);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(96, 60);
            this.songNameLabel.TabIndex = 1;
            this.songNameLabel.Text = "title";
            this.songNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // albumNameLabel
            // 
            this.albumNameLabel.AutoSize = true;
            this.albumNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.albumNameLabel.ForeColor = System.Drawing.Color.White;
            this.albumNameLabel.Location = new System.Drawing.Point(501, 352);
            this.albumNameLabel.Name = "albumNameLabel";
            this.albumNameLabel.Size = new System.Drawing.Size(143, 60);
            this.albumNameLabel.TabIndex = 2;
            this.albumNameLabel.Text = "album";
            this.albumNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // artistNameLabel
            // 
            this.artistNameLabel.AutoSize = true;
            this.artistNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.artistNameLabel.Font = new System.Drawing.Font("Segoe UI Semilight", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.artistNameLabel.ForeColor = System.Drawing.Color.White;
            this.artistNameLabel.Location = new System.Drawing.Point(501, 489);
            this.artistNameLabel.Name = "artistNameLabel";
            this.artistNameLabel.Size = new System.Drawing.Size(119, 60);
            this.artistNameLabel.TabIndex = 3;
            this.artistNameLabel.Text = "artist";
            this.artistNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1351, 772);
            this.Controls.Add(this.artistNameLabel);
            this.Controls.Add(this.albumNameLabel);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.nplabel);
            this.Name = "Form1";
            this.Text = "Zune Rich Presence";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nplabel;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Label albumNameLabel;
        private System.Windows.Forms.Label artistNameLabel;
    }
}

