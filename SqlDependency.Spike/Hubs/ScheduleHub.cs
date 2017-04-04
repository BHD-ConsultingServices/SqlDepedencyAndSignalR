
namespace SqlDependency.Spike.Hubs
{
    using Microsoft.AspNet.SignalR;
    using Microsoft.AspNet.SignalR.Hubs;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ScheduleHub : Hub
    {
        [HubMethodName("updateRaceSchedule")]
        public static void UpdateRaceSchedules()
        {
            var context = GlobalHost.ConnectionManager.GetHubContext<ScheduleHub>();
            context.Clients.All.updateRaceSchedule();
        }
    }
}