using System;
using System.Media;
using System.IO;
using System.Threading;

namespace CyberBot_PART_1
{
    public class CyberBot
    {
        private void Start()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ShowHeader();
            PlayVoiceGreating();
            GetUserName();
            WelcomeUser();
            MenuLoop();

        }

        //================
        //HEADER
        //================
        private void ShowHeader()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("=================================================");
            Console.WriteLine("========CYBERSECURITY AWARENESS BOT==============");
            Console.WriteLine("=================================================");
            Console.WriteLine(@"
      ____      _               ____        _   
     / ___|   _| |__   ___ _ __| __ )  ___ | |_ 
    | |  | | | | '_ \ / _ \ '__|  _ \ / _ \| __|
    | |__| |_| | |_) |  __/ |  | |_) | (_) | |_ 
     \____\__, |_.__/ \___|_|  |____/ \___/ \__|
          |___/                                 
           Stay Safe Online!
");

            Console.ResetColor();

        }

        
    }
}
