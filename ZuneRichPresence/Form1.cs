using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZuneRichPresence
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void changeInfo(string artist, string track, string album)
        {
            songNameLabel.Text = track;
            albumNameLabel.Text = album;
            artistNameLabel.Text = artist;
        }

    }
}
