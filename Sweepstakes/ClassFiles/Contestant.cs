using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant : IParticipant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;    
        public int NotifyId
        {
            get
            {
                return registrationNumber;
            }
            set
            {
                NotifyId = registrationNumber;
            }
        }
        private bool isWinner;
        public bool IsWinner
        {
            get
            {
                return isWinner;
            }
            set
            {
                isWinner = value;
            }
        }

        //constructor
        public Contestant(string firstNameIn, string lastNameIn, string emailIn, int registrationNumberIn)
        {
        this.firstName = firstNameIn;
        this.lastName = lastNameIn;
        this.email = emailIn;
        this.registrationNumber = registrationNumberIn;
        this.isWinner = false;
        }

        //member methods
        public void Notify(IParticipant participant, string nameOfSweepstakes, string nameOfWinner)
        {
            UserInterface.NotifyParticipants(nameOfSweepstakes, nameOfWinner);

            if (participant.IsWinner)
            {
                UserInterface.NotifyWinner(nameOfWinner);
            }
        }
    }
}
