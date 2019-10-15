using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        //member variables
        Stack stack = new Stack();
            
        //constructor
        public SweepstakesStackManager()
        {
            Console.WriteLine("new SweepstakesStackManager.stack");
            Console.WriteLine("stack.count = " + stack.Count);
        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakesIn)
        {
            stack.Push(sweepstakesIn);
        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop() as Sweepstakes;
        }
    }
}
