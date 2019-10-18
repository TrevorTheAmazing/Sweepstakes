using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesQueueManager : ISweepstakesManager
    {
        //member variables
        //10-18-19 TLC Queue queue = new Queue();
        Queue<Sweepstakes> queue = new Queue<Sweepstakes>();
            
        //constructor
        public SweepstakesQueueManager()
        {

        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakesIn)
        {
            queue.Enqueue(sweepstakesIn);
        }

        public Sweepstakes GetSweepstakes()
        {
            //10-18-19 TLC return queue.Dequeue() as Sweepstakes;
            return queue.Dequeue();
        }
    }
}

