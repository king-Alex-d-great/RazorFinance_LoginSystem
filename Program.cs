using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Threading.Tasks;

namespace RazorFinanceLoginSystem
{
    class Program
    {
        Database database = new Database();
       public static void Main()
       {
            var application = new Application();
            application.Run().Wait();
       }         
    }
}
