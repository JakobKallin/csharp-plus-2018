using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Många varianter är möjliga. Denna försöker efterlikna vad en människa skulle göra "för hand".
            int previous = 1;
            int grains = 1;
            for (int i = 2; i <= 24; i += 1)
            {
                grains += previous * 2;
                previous = previous * 2;
            }
            Console.WriteLine(grains);
        }
    }
}
