using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface IParticipant
    {
        int NotifyId { get; set; }
        bool IsWinner { get; set; }
        void Notify(IParticipant participant, string nameOfSweepstakes, string nameOfWinner);
    }
}
