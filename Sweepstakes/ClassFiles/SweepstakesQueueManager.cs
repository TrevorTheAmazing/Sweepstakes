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
        Queue queue = new Queue();
            
        //constructor
        public SweepstakesQueueManager()
        {
            this.queue = queue;
        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakesIn)
        {
            queue.Enqueue(sweepstakesIn);
        }

        public Sweepstakes GetSweepstakes()
        {
            return queue.Dequeue() as Sweepstakes;
        }
    }
}

