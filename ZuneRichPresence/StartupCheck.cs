using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
//taken from ZuzeMe: a Last.FM scrobbler for the Zune desktop program. https://github.com/dumbie/ZuseMe
namespace ZuneRichPresence
{
    class StartupCheck
    {
        public StartupCheck()
        {
            if (Process.GetProcessesByName("ZuneRichPresence").Length > 1)
            {
                MessageBox.Show("ZRP is already running.", "Zune Rich Presence");
                Environment.Exit(1);
            }

            if (Process.GetProcessesByName("Zune").Length == 0)
            {
                LaunchZune LaunchZune = new LaunchZune();
            }
        }
    }
}
