using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//taken from ZuzeMe: a Last.FM scrobbler for the Zune desktop program. https://github.com/dumbie/ZuseMe
namespace ZuneRichPresence
{
    public partial class ReceiveSong : Form
    {
        //Hide window from alt+tab
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        public ReceiveSong()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x4A)
            {
                COPYDATASTRUCT cds = (COPYDATASTRUCT)m.GetLParam(typeof(COPYDATASTRUCT));
                string Message = ReceiveMessage.GetMessageString(cds);
                //Console.WriteLine("Debug: " + Message);

                if (Message.StartsWith("ZUNE"))
                {
                    string[] Split = Message.Split(new string[] { "\\0" }, StringSplitOptions.None);

                    if (Split.Length >= 7)
                    {
                        string ZuneRunning = Split[2];
                        string ZuneTrack = Split[4];
                        string ZuneArtist = Split[5];
                        string ZuneAlbum = Split[6];

                        PlayingInfo PlayingInfo = new PlayingInfo();
                        PlayingInfo.ZuneRunning = 1;
                        PlayingInfo.ZuneTrack = ZuneTrack;
                        PlayingInfo.ZuneArtist = ZuneArtist;
                        PlayingInfo.ZuneAlbum = ZuneAlbum;
                        PlayingInfo.SendSongInfo();
                    }
                    else
                    {
                        PlayingInfo PlayingInfo = new PlayingInfo();
                        PlayingInfo.ZuneRunning = 0;
                        PlayingInfo.SendSongInfo();
                    }
                }
            }
            base.WndProc(ref m);
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct COPYDATASTRUCT
    {
        public UIntPtr dwData;
        public int cbData;
        public IntPtr lpData;
    }

    public class ReceiveMessage
    {
        public static unsafe string GetMessageString(COPYDATASTRUCT cds)
        {
            string msg = string.Empty;

            unsafe
            {
                char* x = (char*)cds.lpData.ToPointer();

                for (int i = 0; i < cds.cbData; i++)
                {
                    msg += *x;
                    x++;
                }
            }
            return msg;
        }
    }
}