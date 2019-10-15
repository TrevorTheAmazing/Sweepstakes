using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
        string name;

        //constructor
        public Sweepstakes(string nameIn)
        {
            this.name = nameIn;
        }

        //member methods
        public void RegisterContestant(Contestant contestant)
        {

        }

        public Contestant PickWinner()
        {
            Contestant contestant = new Contestant();
            return contestant;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("contestant info");
        }

        public string NewRegistrationNumber()
        {
            return "";
        }
    }
}
