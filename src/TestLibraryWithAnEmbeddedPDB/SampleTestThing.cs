using System;
using System.Threading.Tasks;

namespace TestLibraryWithAnEmbeddedPDB
{
    public class SampleTestThing
    {
        public DateTime GetDateTime()
        {
            // Do some useless code but enables a developer to step into this method and see stuff happen.
            int i = 0;
            i++;

            return DateTime.UtcNow;
        }

        public async Task<DateTime> GetDateTimeAsync()
        {
            // Do some more usless stuff.
            int y = 0;
            y++;

            await Task.Delay(2000); // Hang for 2 seconds.

            return DateTime.UtcNow;
        }
    }
}
