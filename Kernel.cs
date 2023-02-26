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
        bool options_mode = false; //default is false

        // language
        bool english = true; //default is true
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
            if (options_mode == true)
            {
                Console.Write("Text Here (!OPTIONS MODE!): ");
            }
            else
            {
                Console.Write("Text Here: ");
            }
            var input = Console.ReadLine();
            Console.WriteLine(input);

            switch(input) // switch is better
            {
                // language command
                case "run options -language -english":
                    Console.Clear();
                    Console.WriteLine("English Language Mode 'USING'");
                    english = true;
                    break;

                // empty command
                case "":
                    Console.WriteLine("ERROR: Command cannot empty");
                    break;

                // normall command
                case "run options -language":
                    if (options_mode == true)
                    {
                        Console.Clear();
                        Console.WriteLine("To Disable it, type 'run options -mode -disable'");
                        Console.WriteLine("To Change language, type command again with '-<language want to change>");
                        Console.WriteLine("1. English");
                    }
                    else
                    {
                        Console.WriteLine("Options Mode is not enable\nTo Enable it, type 'run options -mode -enable'");
                    }
                    break;

                case "run options -mode -enable":
                    if (options_mode == true)
                    {
                        Console.WriteLine("You already enable options mode");
                    }
                    else
                    {
                        Console.WriteLine("Successful Enable Options Mode");
                    }
                    break;

                case "run options -mode -disable":
                    if (options_mode == false)
                    {
                        Console.WriteLine("You already disable options mode");
                    }
                    else
                    {
                        Console.WriteLine("Successful Disable Options Mode");
                    }
                    break;

                case "run options":
                    if (options_mode == true)
                    {
                        Console.Clear();
                        Console.WriteLine("To Disable it, type 'run options -mode -disable'");
                        Console.WriteLine("\n-OPTIONS COMMAND-");
                        Console.WriteLine("1. -language");
                    }
                    else
                    {
                        Console.WriteLine("Options Mode is not enable\nTo Enable it, type 'run options -mode -enable'");
                    }
                    break;

                case "run":
                    Console.WriteLine("ERROR: Missing command to run");
                    break;

                case "run help":
                    Console.Clear();
                    Console.WriteLine("-ABOUT OF THE CMDOS-");
                    Console.WriteLine("1. 'run help': Display this text");
                    Console.WriteLine("2. 'run clear': Clear all text");
                    Console.WriteLine("3. 'run about': Display all text for about this OS");
                    Console.WriteLine("4. 'run shutdown': Shutdown and turn off the OS");
                    Console.WriteLine("5. 'run restart': Restart the OS");
                    Console.WriteLine("6. 'run copyright': A CopyRight Text will display");
                    break;

                case "run copyright":
                    Console.Clear();
                    Console.WriteLine("COPYRIGHT");
                    Console.WriteLine("A free, open-source operating system");
                    Console.WriteLine("You can rebuild this operating system");
                    Console.WriteLine("But you need credits of the member who made this os");
                    Console.WriteLine("\nThe Source can find on https://github.com/Hoovy-Team/cmdOS-NEW");
                    break;

                case "run clear":
                    Console.Clear();
                    break;

                case "run about":
                    Console.Clear();
                    Console.WriteLine("-ABOUT OF THE CMDOS-");
                    Console.WriteLine("cmdOS: version " + VERSION);
                    Console.WriteLine("-Who made this?-");
                    Console.WriteLine("1. Huy1234TH: Main of this OS");
                    Console.WriteLine("2. MemeHoovy: Second of the coder");
                    break;

                case "run shutdown":
                    Console.Clear();
                    Console.WriteLine("We are Shutdown the OS");
                    Cosmos.System.Power.Shutdown();
                    break;

                case "run restart":
                    Console.Clear();
                    Console.WriteLine("We are Restart the OS");
                    Cosmos.System.Power.Reboot();
                    break;

                case "run checkSYSTEM":
                    Console.Clear();
                    Console.WriteLine("cmdOS: v" + VERSION);
                    break;

                default:
                    Console.WriteLine("ERROR: A Unknow command");
                    break;
            }

        /*    if (input == "run getCurrentDirectory" && options_mode == false)
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
        }*/
    }
}