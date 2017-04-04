
namespace SqlDependency.Spike
{
    using global::Spike.Contracts;
    using SqlDependency.Spike.Models;
    using System.Collections.Generic;
    using System.Linq;

    public static class ExtensionMapping
    {
        public static IEnumerable<ScheduleViewModel> Map(this Schedules data)
        {
            var mapped = data.Data.Select(x => x.Map());
            return mapped;
        }

        public static ScheduleViewModel Map(this RaceSchedule original)
        {
            var mapped = new ScheduleViewModel
            {
                RaceNo = original.RaceNo.ToString(),
                HorseName = original.HorseName,
                RaceTime = original.RaceTime,
                Rider = original.Rider,
                Status = original.Status
            };

            return mapped;
        }
    }
}