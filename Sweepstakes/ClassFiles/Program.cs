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
            //10-18-19 TLC int managerType = -1;

            UserInterface.Welcome();

            //10-18-19 TLC UserInterface.SetManagerType("Would you like to use the Queue manager?", 0, 1, ref managerType);-
            
            MarketingFirm newFirm = new MarketingFirm(ManagerFactory.SetManagerType("Would you like to use the 'stack' or 'queue' manager?"));

            newFirm.CreateSweepstakes("Black Friday");
            //newFirm.CreateSweepstakes("Spring Break"));

            newFirm.GenerateSweepstakesWinner();
            UserInterface.ProgramEnd();
            Console.ReadLine();
            
        }
    }
}