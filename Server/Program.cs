using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            bool thing = true;
            Server test = new Server();
            test.Run();
            while(thing == true)
            {
                test.SecondRun();
            }
            Console.ReadLine();
        }
    }
}
