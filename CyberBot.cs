using System;
using System.Media;
using System.IO;
using System.Threading;

namespace CyberBot_PART_1
{
    public class CyberBot
    {
        private string userName;

        public void Start()
        {
            Console.Title = "Cybersecurity Awareness Bot";

            ShowHeader();
            PlayVoiceGreeting();
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

        //================
        // VOICE GREETING
        //================

        private void PlayVoiceGreeting()
        {
            try
            {
                string path = "welcome.wav"; // file in project folder
                SoundPlayer player = new SoundPlayer(path);
                player.Load();        // loads audio
                player.PlaySync();    // plays before continuing
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("🔊 Voice greeting could not play.");
                Console.WriteLine("Error: " + ex.Message);
                Console.ResetColor();
            }
        }
            //================
            //GET USER NAME
            //================

            private void GetUserName()
        {
            Console.Write("\nEnter your name: ");
            userName = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Name cannot be empty. Try again: ");
                userName = Console.ReadLine();
            }
        }

        }
    }
    

