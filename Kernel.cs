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
            Console.WriteLine(input);

            if (input == "")
            {
                Console.WriteLine("ERROR: Missing of 'run' command");
            }

            if (input == "run")
            {
                Console.WriteLine("ERROR: Missing command to run");
            }

            if (input == "run help")
            {
                Console.Clear();
                Console.WriteLine("-ABOUT OF THE CMDOS-");
                Console.WriteLine("1. 'run help': Display this text");
                Console.WriteLine("2. 'run clear': Clear all text");
                Console.WriteLine("3. 'run about': Display all text for about this OS");
                Console.WriteLine("4. 'run shutdown': Shutdown and turn off the OS");
                Console.WriteLine("5. 'run restart': Restart the OS");
            }

            if (input == "run clear")
            {
                Console.Clear();
            }

            if (input == "run about")
            {
                Console.Clear();
                Console.WriteLine("-ABOUT OF THE CMDOS-");
                Console.WriteLine("cmdOS: version 0.1.3");
                Console.WriteLine("-Who made this?-");
                Console.WriteLine("1. Huy1234TH: Main of this OS");
            }

            if (input == "run shutdown")
            {
                Console.Clear();
                Console.WriteLine("We are Shutdown the OS");
                Cosmos.System.Power.Shutdown();
            }

            if (input == "run restart")
            {
                Console.Clear();
                Console.WriteLine("We are Restart the OS");
                Cosmos.System.Power.Reboot();
            }

            if (input == "install this stupid os" || input == "install this great os" || input == "install" || input == "install os")
            {
                // Console.Clear();
                Console.WriteLine("no");
            }

            if (input == "run checkSYSTEM")
            {
                Console.Clear();
                Console.WriteLine("cmdOS: v0.1.3");
            }
        }
    }
}
