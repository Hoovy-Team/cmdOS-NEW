using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace cmdOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Wellcome to cmdOS!!, please type 'run help' for more command");
            Console.WriteLine("cmdOS v0.1.3");
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
            }

            if (input == "run options" && options_mode == false)
            {
                options_mode = true;
                Console.Clear();
                Console.WriteLine("-OPTIONS SETTING-");
                Console.WriteLine("1. Language: Change language");
                Console.WriteLine("2. Exit: Exit with Saving");

                if (input == "language" && options_mode == true || input == "Language" && options_mode == true)
                {
                    Console.Clear();
                    Console.WriteLine("-LANGUAGE-");
                    Console.WriteLine("1. English");
                    Console.WriteLine("2. Default");

                    if (input == "English" && options_mode == true || input == "english" && options_mode == true || input == "Default" && options_mode == true || input == "default" && options_mode == true)
                    {
                        Console.Clear();
                        Console.WriteLine("Language is now is English");
                        lang_1 = true;
                    }
                }

                if  (input == "Exit" && options_mode == true || input == "exit" && options_mode == true)
                {
                    options_mode = false;
                    Console.Clear();
                }
            }

            if (input == "run clear" && options_mode == false)
            {
                Console.Clear();
            }

            if (input == "run about" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("-ABOUT OF THE CMDOS-");
                Console.WriteLine("cmdOS: version 0.1.3");
                Console.WriteLine("-Who made this?-");
                Console.WriteLine("1. Huy1234TH: Main of this OS");
            }

            if (input == "run shutdown" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("We are Shutdown the OS");
                Cosmos.System.Power.Shutdown();
            }

            if (input == "run restart" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("We are Restart the OS");
                Cosmos.System.Power.Reboot();
            }

            if (input == "install this stupid os" && options_mode == false || input == "install this great os" && options_mode == false || input == "install" && options_mode == false || input == "install os" && options_mode == false)
            {
                // Console.Clear();
                Console.WriteLine("no");
            }

            if (input == "run checkSYSTEM" && options_mode == false)
            {
                Console.Clear();
                Console.WriteLine("cmdOS: v0.1.3");
                if (lang_1 == true)
                {
                    Console.WriteLine("Language: English");
                }
                else
                {
                    Console.WriteLine("Language: English");
                }
            }
        }
    }
}
