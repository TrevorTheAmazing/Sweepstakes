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
            int managerType = -1;

            UserInterface.Welcome();

            //set managerType using the UserInterface class
            UserInterface.SetManagerType("Would you like to use the Queue manager?", 0, 1, ref managerType);
            
            MarketingFirm newFirm = new MarketingFirm(managerType);

            newFirm.CreateSweepstakes("Black Friday");
            //newFirm.CreateSweepstakes("Spring Break"));

            newFirm.GenerateSweepstakesWinner();
            UserInterface.ProgramEnd();
            Console.ReadLine();
            
        }
    }
}
