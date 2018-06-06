using System;

namespace MyFirstGitHubApp
{
    class Program
    {
        static void anotherAuxMeth() {
            Console.WriteLine("Sorry for having bothered you");
                }
        static void auxMeth()
        {
            Console.WriteLine("writing something");
        }
        static void Main(string[] args)
        {
            auxMeth();
            anotherAuxMeth();
            Console.ReadLine();
        }
    }
}
