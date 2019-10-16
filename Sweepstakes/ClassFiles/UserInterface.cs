using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sweepstakes.ClassFiles;

namespace Sweepstakes
{
    public static class UserInterface
    {
        //member variables
        



        //member methods
        public static void DisplayWinner(Sweepstakes sweepstakesIn, Contestant contestantIn)
        {
            Console.WriteLine( contestantIn.firstName + ", Contestant #" + contestantIn.registrationNumber + " has won the " + sweepstakesIn.name + " sweepstakes!");
            Console.ReadLine();
        }

        public static void SetManagerType(string prompt, int opt1, int opt2, ref int managerType)
        {
            int tempInt = 0;
            Console.WriteLine("There are two different types of manager types: Stack, and Queue.");
            if (Validation.GetUserInput(prompt, "bool")=="1")
            {
                tempInt = 1;
            }
            managerType = tempInt;
        }

        public static void Welcome()
        {
            Console.WriteLine("Welcome to Sweepstakes!");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static string GetContestantFirstName()
        {
            string tempString = Validation.GetUserInput("Please enter the contestant's first name: ", "str");
            return tempString;
        }
        public static string GetContestantLastName()
        {
            string tempString = Validation.GetUserInput("Please enter the contestant's last name: ", "str");
            return tempString;
        }
        public static string GetContestantEmail()
        {
            string tempString = Validation.GetUserInput("Please enter the contestant's email address: ", "str");
            return tempString;
        }
    }
}
