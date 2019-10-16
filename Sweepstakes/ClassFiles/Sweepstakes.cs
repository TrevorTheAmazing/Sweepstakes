using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweepstakes.ClassFiles;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        public string name;

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
                int tempDictNdx = random.Next(10000, 100000);
                if (contestants.TryGetValue(tempDictNdx, out tempWinner))
                {
                    success = true;                    
                }                    

            } while (!success);

            return tempWinner;
        }

        public void PrintContestantInfo(Sweepstakes sweepstakesIn, Contestant contestantIn)
        {
            UserInterface.DisplayWinner(sweepstakesIn, contestantIn);            
        }

     
    }
}
