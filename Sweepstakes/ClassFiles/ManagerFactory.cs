using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public static class ManagerFactory
    {
        public static ISweepstakesManager SetManagerType(string managerTypeIn)
        {
            managerTypeIn = UserInterface.SetManagerType(managerTypeIn);
            ISweepstakesManager manager = null;
            switch (managerTypeIn)
            {
                case ("stack"):
                    {
                        manager =  new SweepstakesStackManager();
                        break;
                    }
                case ("queue"):
                    {
                        manager = new SweepstakesQueueManager();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            return manager;
        }
    }
}
