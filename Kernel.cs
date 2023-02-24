using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Diagnostics;

namespace cmdOS
{
    public class Kernel : Sys.Kernel
    {
        readonly string VERSION = "0.1.3";

        bool SAFE_MODE = false;

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Wellcome to cmdOS!!, please type 'run help' for more command");
            Console.WriteLine("cmdOS v" + VERSION);

            Sys.Graphics.VGAScreen.PixelHeight = 600;
            Sys.Graphics.VGAScreen.PixelWidth = 800;
        }

        protected override void Run()
        {
            Console.Write("Text Here: ");
            var input = Console.ReadLine();
            // Console.WriteLine(input);

            // Language
            bool lang_1 = false;

            // Options Time
            bool options_mode = false;

            if (input == "" && options_mode == false)
            {
                if (lang_1 == true)
                {
                    Console.WriteLine("ERROR: Missing of 'run' command");
                }
                else if (lang_1 == false)
                {
                    Console.WriteLine("ERROR: Missing of 'run' command");
                }   
            }

            if (input == "run" && options_mode == false)
            {
                Console.WriteLine("ERROR: Missing command to run");
            }

            if (input == "run help" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("-ABOUT OF THE CMDOS-");
                Console.WriteLine("1. 'run help': Display this text");
                Console.WriteLine("2. 'run clear': Clear all text");
                Console.WriteLine("3. 'run about': Display all text for about this OS");
                Console.WriteLine("4. 'run shutdown': Shutdown and turn off the OS");
                Console.WriteLine("5. 'run restart': Restart the OS");
                Console.WriteLine("6. 'run options': Display all of about options");
                Console.WriteLine("7. 'run copyright': A CopyRight Text will display");
                Console.WriteLine("8. 'run getCurrentDirectory': Will return the current directory, fails if safe mode is enabled. (disabled by default)");
            }

            if (input == "run copyright" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("COPYRIGHT");
                Console.WriteLine("A free, open-source operating system");
                Console.WriteLine("You can rebuild this operating system");
                Console.WriteLine("But you need credits of the member who made this os");
                Console.WriteLine("\nThe Source can find on https://github.com/Hoovy-Team/cmdOS-NEW");
            }

            if (input == "run options" && options_mode == false)
            {
                options_mode = true;
                Console.Clear();
                Console.WriteLine("-OPTIONS SETTING-");
                Console.WriteLine("1. Language: Change language");
                Console.WriteLine("2. run checkSYSTEM: Check the OS");
                Console.WriteLine("3. options off: Turn off options mode");
            }

            if (input == "language" && options_mode == true || input == "Language" && options_mode == true)
            {
                Console.Clear();
                Console.WriteLine("-LANGUAGE-");
                Console.WriteLine("1. English");
                Console.WriteLine("2. Default");
            }

            if (input == "options off" && options_mode == true)
            {
                options_mode = false;
                Console.Clear();
                Console.WriteLine("Options Mode was off");
            }

            if (input == "English" && options_mode == true || input == "english" && options_mode == true || input == "Default" && options_mode == true || input == "default" && options_mode == true)
            {
                Console.Clear();
                Console.WriteLine("Language is now is English");
                lang_1 = true;
            }

            if (input == "run clear" && options_mode == false)
            {
                Console.Clear();
            }

            if (input == "run about" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("-ABOUT OF THE CMDOS-");
                Console.WriteLine("cmdOS: version " + VERSION);
                Console.WriteLine("-Who made this?-");
                Console.WriteLine("1. Huy1234TH: Main of this OS");
                Console.WriteLine("2. MemeHoovy: New Coder");
            }

            if (input == "run shutdown" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("We are Shutdown the OS");
                Sys.Power.Shutdown();
            }

            if (input == "run restart" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("We are Restart the OS");
                Sys.Power.Reboot();
            }

            if (input == "install this stupid os" && options_mode == false || input == "install this great os" && options_mode == false || input == "install" && options_mode == false || input == "install os" && options_mode == false)
            {
                // Console.Clear();
                Console.WriteLine("no");
            }

            if (input == "run checkSYSTEM" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("cmdOS: v " + VERSION);
                if (lang_1 == true)
                {
                    Console.WriteLine("Language: English");
                }
                else
                {
                    Console.WriteLine("Language: English");
                }
            }

            if (input == "run getCurrentDirectory" && options_mode == false)
            {
                Console.Clear();
                if (!SAFE_MODE)
                    Console.WriteLine("Current directory is: " + System.IO.Directory.GetCurrentDirectory());
                else
                    Console.WriteLine("Safe mode is enabled, command was not runned");
            }

            if (input == "run openWebsite" && options_mode == false)
            {
                Console.WriteLine("Waiting for input: ");
                var http = Console.ReadLine();

                if (SAFE_MODE) return;

                if (http != null && http.StartsWith("https://www.") || http.StartsWith("http://www."))
                {
                    Process f = new Process();

                    ProcessStartInfo processStartInfo = new ProcessStartInfo();

                    f.StartInfo = processStartInfo;

                    if (!f.Start())
                    {
                        Console.WriteLine("Site failed to start.");
                    }
                    Process.Start(http);
                }
                else
                {
                    Console.WriteLine("Input cannot be blank");
                }
            }
        }
    }
}
