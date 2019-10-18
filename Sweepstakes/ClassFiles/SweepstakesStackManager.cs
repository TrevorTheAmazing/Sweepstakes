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
        //10-18-19 TLC Stack stack = new Stack();
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
            
        //constructor
        public SweepstakesStackManager()
        {

        }

        //member methods
        public void InsertSweepstakes(Sweepstakes sweepstakesIn)
        {
            stack.Push(sweepstakesIn);
        }

        public Sweepstakes GetSweepstakes()
        {
            //10-18-19 TLC return stack.Pop() as Sweepstakes;
            return stack.Pop();
        }
    }
}
