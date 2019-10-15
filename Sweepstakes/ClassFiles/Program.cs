using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int StackManager = 0;
            int QueueManager = 1;
            int managerType;
            //set managerType using the UserInterface class
            //UserInterface.SetManagerType(string prompt, int opt1, int opt2, ref managerType )

            MarketingFirm newFirm = new MarketingFirm(managerType);
            newFirm.CreateSweepstakes("Black Friday");
        }
    }
}
