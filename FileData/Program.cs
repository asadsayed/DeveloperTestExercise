using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is the functionality you would like to perform? ");
            string func = Console.ReadLine();
            Console.WriteLine("\nWhat is the file name? ");
            string name = Console.ReadLine();
            if (func == "–v" || func == "--v" || func == "/v" || func ==  "--version" )
            {
                string version;
                FileDetails obj = new FileDetails();
                version = obj.Version(name);
                Console.WriteLine($"The version of the file {name} is {version}");
            }
            else if(func == "–s" || func == "--s" || func == "/s" || func == "--size")
            {
                int size;
                FileDetails obj = new FileDetails();
                size = obj.Size(name);
                Console.WriteLine($"The size of the file {name} is {size}");
            }
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}
