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
            this.contestants = contestants;
        }

        //member methods
        public void RegisterContestant(Contestant contestantIn)
        {
            contestants.Add(contestantIn.registrationNumber, contestantIn);
        }

        public Contestant PickWinner()
        {
            Contestant tempWinner;
            //pick a random dictionary regNum winningNumber
            //foreach contestant in contestants
            //if contestant.registrationNumber = winningNumber
            return tempWinner;

        }

        public void PrintContestantInfo(Contestant contestant)
        {
            //
            Console.WriteLine("contestant info");
        }

        //public string NewRegistrationNumber()
        //{
        //    return "";
        //}
    }
}
