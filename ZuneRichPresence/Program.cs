using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DiscordRPC;


namespace ZuneRichPresence
{
    class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        
        
        [STAThread]
        public static void Main()
        {
            DiscordControl DiscordControl = new DiscordControl();
            DiscordControl.Init();
            StartupCheck StartupCheck = new StartupCheck();
            Console.WriteLine("Waiting for a song to begin or change...");
            
            ReceiveSong ReceiveSong = new ReceiveSong();
            ReceiveSong.Show();
            
            
            //DiscordControl.ChangeStatus();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }

        
        

        
    }
}
