using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class UserInterface
    {
        //member variables
        

        //constructor
        public UserInterface()
        {

        }

        //member methods
        public void DisplayWinner(Sweepstakes sweepstakesIn, Contestant contestantIn)
        {
            Console.WriteLine( contestantIn.firstName + ", Contestant #" + contestantIn.registrationNumber + " has won the " + sweepstakesIn.name + " sweepstakes!");
            Console.ReadLine();
        }
    }
}
