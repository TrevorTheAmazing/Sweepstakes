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
        //member methods
        public static void DisplayWinner(Sweepstakes sweepstakesIn, Contestant contestantIn)
        {
            Console.WriteLine( "Sweepstakes/PrintContestantInfo/DisplayWinner: " + contestantIn.firstName + ", Contestant #" + contestantIn.registrationNumber + " has won the " + sweepstakesIn.name + " sweepstakes!");
            Console.ReadLine();
        }

        //10-18-19 TLC public static void SetManagerType(string prompt, int opt1, int opt2, ref int managerType)
        //public static void SetManagerType(string prompt)
        public static string SetManagerType(string prompt)
        {
            //10-18-19 TLC int tempInt = 0;
            //10-18-19 TLC Console.WriteLine("There are two different types of manager types: Stack, and Queue.");
            //10-18-19 TLC if (Validation.GetUserInput(prompt, "bool")=="1")

            //ISweepstakesManager tempManager;
            string tempResult = "";

            if (Validation.GetUserInput(prompt, "str") == "stack")
            {
                //tempInt = 1;
                tempResult = "stack";
                
            }
            else
            {
                return "queue";
            }

            //10-18-19 TLC managerType = tempInt;
            return tempResult;
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

        public static void NotifyParticipants(string nameOfSweepstakes, string nameOfWinner)
        {
            Console.WriteLine("TO ALL P'PANTS: The " + nameOfSweepstakes + " sweepstakes are over.");
            Console.WriteLine("TO ALL P'PANTS: " + nameOfWinner + " won the " + nameOfSweepstakes + " sweepstakes.");
            Console.ReadLine();
        }

        public static void NotifyWinner(string nameOfWinner)
        {
            Console.WriteLine("TO THE WINNER: ... and you, " + nameOfWinner + ", have won!");
            Console.ReadLine();
        }

        public static void ProgramEnd()
        {
            Console.WriteLine("End of program.");
        }

    }
}
