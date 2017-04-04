using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spike.Contracts
{
    public class RaceSchedule
    {
        public int RaceNo { get; set; }

        public string HorseName { get; set; }

        public string Rider { get; set; }

        public DateTime RaceTime { get; set; }

        public string Status { get; set; }
    }
}
