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
        public Contestant(string firstNameIn, string lastNameIn, string emailIn, int registrationNumberIn)
        {
        this.firstName = firstNameIn;
        this.lastName = lastNameIn;
        this.email = emailIn;
        this.registrationNumber = registrationNumberIn;
        }

        //member methods

    }
}
