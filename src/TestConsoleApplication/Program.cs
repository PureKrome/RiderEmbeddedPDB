using System;
using System.Threading.Tasks;
using TestLibraryWithAnEmbeddedPDB;

namespace TestConsoleApplication
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting test application.");

            var foo = new SampleTestThing();

            Console.WriteLine(foo.GetDateTime());
            Console.WriteLine(await foo.GetDateTimeAsync());
        }
    }
}
