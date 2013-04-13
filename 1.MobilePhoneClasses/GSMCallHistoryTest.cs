using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GSMCallHistoryTest
{

    static void Main()
    {
       
        GSM nokia = new GSM("N7", "Nokia");
        nokia.AddCall(360);
        nokia.AddCall(500);
        nokia.AddCall(1500);
        nokia.DisplayCalls();
        Console.WriteLine("The total price of the calls with 0.37st/min is {0}", nokia.CallPrice(0.37));
        nokia.DeleteCall(1500);
        nokia.DisplayCalls();
        Console.WriteLine("The total price of the calls without the longest call is {0}", nokia.CallPrice(0.37));

    }
}

