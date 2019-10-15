using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        string name;        

        //constructor
        public Sweepstakes(string nameIn)
        {
            this.name = nameIn;
        }

        //member methods
        public void RegisterContestant(Contestant contestantIn)
        {
            contestants.Add(contestantIn.registrationNumber, contestantIn);
        }

        public Contestant PickWinner()
        {
            bool success = false;
            Random random = new Random();
            Contestant tempWinner = null;

            do
            {
                //pick a random dictionary regNum winningNumber
                int tempDictNdx = random.Next(0, contestants.Count);
                //if contestant.registrationNumber = winningNumber
                if (contestants.TryGetValue(tempDictNdx, out tempWinner))
                {
                    success = true;                    
                }                    

            } while (!success);

            return tempWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("call UserInterface.DisplayWinner(Contestant)");
        }
    }
}
