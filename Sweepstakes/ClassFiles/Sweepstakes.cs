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
        List<IParticipant> participants = new List<IParticipant>();
        public string name;
        public int winnerId;
        public IParticipant notifyId;

        //constructor
        public Sweepstakes(string nameIn)
        {
            this.name = nameIn;
            this.winnerId = -1;
        }

        //member methods
        public void RegisterContestant(Contestant contestantIn)
        {
            contestants.Add(contestantIn.registrationNumber, contestantIn);
            Participate(contestantIn);            
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
                    winnerId = tempWinner.registrationNumber;
                    success = true;                    
                }                    

            } while (!success);

            return tempWinner;
        }

        public void PrintContestantInfo(Sweepstakes sweepstakesIn, Contestant contestantIn)
        {
            UserInterface.DisplayWinner(sweepstakesIn, contestantIn);            
        }

        public void Participate(IParticipant participantIn)
        {
            participants.Add(participantIn);
        }

        public void NotifyContestants()
        {
            string nameOfWinner = "";
            Contestant tempWinner;

            if (contestants.TryGetValue(this.winnerId, out tempWinner))
            {
                nameOfWinner = tempWinner.firstName + " " + tempWinner.lastName;
            }

            foreach (IParticipant participant in participants)
            {
                participant.IsWinner = (participant.NotifyId == this.winnerId);
                participant.Notify(participant, this.name, nameOfWinner);
            }

        }
    }
}
