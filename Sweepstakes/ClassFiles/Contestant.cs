using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;

        //constructor
        public Contestant(int registrationNumberIn, string firstNameIn)
        {
        this.firstName = firstNameIn;
        this.lastName = "";
        this.email = "";
        this.registrationNumber = registrationNumberIn;
        }

        //member methods
    }
}
