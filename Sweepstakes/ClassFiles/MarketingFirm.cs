using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class MarketingFirm
    {
        //member variables
        Sweepstakes sweepstakes;
        ISweepstakesManager sweepstakesManager;
        Random random = new Random();

        //constructor
        public MarketingFirm(int managerTypeIn)
        {
            switch (managerTypeIn)
            {
                case 0:
                    {
                        this.sweepstakesManager = new SweepstakesStackManager();
                        break;
                    }
                case 1:
                    {
                        this.sweepstakesManager = new SweepstakesQueueManager();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        //member methods
        public void CreateSweepstakes(string newSweepstakesNameIn)
        {            
            Sweepstakes tempSweepstakes = CreateContestant(new Sweepstakes(newSweepstakesNameIn));
            sweepstakesManager.InsertSweepstakes(tempSweepstakes);
        }

        public Sweepstakes CreateContestant(Sweepstakes sweepstakes)
        {
            for (int i = 0; i < 100; i++)
            {
                //get user input for name/email
                //loop through contestants
                //if they are already registered, reject
                //else create
                string tempFirstName = "Contestant";
                string tempLastName = i.ToString();
                string tempEmail = tempFirstName + "." + tempLastName + "@email.com";
                int tempRegNum = GenerateRegistrationNumber(random);
                Contestant tempContestant = new Contestant(tempFirstName, tempLastName, tempEmail, tempRegNum);
                try
                {
                    sweepstakes.RegisterContestant(tempContestant);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                    tempContestant.registrationNumber = GenerateRegistrationNumber(random);
                    sweepstakes.RegisterContestant(tempContestant);
                }
            }                                                            
            return sweepstakes;
        }

        private int GenerateRegistrationNumber(Random randomIn)
        {
            return randomIn.Next(10000, 100000);
        }

        public void GenerateSweepstakesWinner()
        {
            Sweepstakes tempSweepstakes = sweepstakesManager.GetSweepstakes();
            Contestant tempWinner = tempSweepstakes.PickWinner();
            tempSweepstakes.PrintContestantInfo(tempSweepstakes, tempWinner);            
        }
    }
}
