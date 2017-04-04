using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SqlDependency.Spike.Models
{
    public class ScheduleViewModel
    {
        public string RaceNo { get; set; }

        public string HorseName { get; set; }

        public string Rider { get; set; } 

        public DateTime RaceTime { get; set; }

        public string Status { get; set; }
    }
}