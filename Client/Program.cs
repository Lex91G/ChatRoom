using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Main = true;
           
                Client client = new Client("192.168.0.156", 9999);
               while(Main = true)
            {
                client.Send();
                client.Recieve();
                
            
            }
        }
    }
}
