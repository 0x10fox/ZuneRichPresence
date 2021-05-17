using System;
using System.Collections.Generic;
using System.Text;
using DiscordRPC;

namespace ZuneRichPresence
{
    class DiscordControl
    {
        public DiscordRpcClient client { get; private set; }
        public void Init()
        {
            client = new DiscordRpcClient("842519415345643520");
            client.Initialize();
        }
        public void ChangeStatus(string artist, string track, string album)
        {
            client.SetPresence(new RichPresence()
            {
                Details = "Example Project",
                State = "csharp example",
                Assets = new Assets()
                {
                    LargeImageKey = "logo",
                    LargeImageText = "Zune"
                    
                }
            });
            client.Invoke();
        }
    }
}
