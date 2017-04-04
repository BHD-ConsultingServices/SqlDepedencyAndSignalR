
namespace Spike.Orchestrations
{
    using Spike.Contracts;
    using System;
    using Spike.Commons;
    using Spike.Adapters.Contracts;

    public class RaceOrchestrations : IRaceOrchestrations
    {
        private readonly IRaceAdapters raceAdapter;

        public RaceOrchestrations(IRaceAdapters raceAdapter)
        {
            this.raceAdapter = raceAdapter;
        }

        public DataResponse<Schedules> GetSchedules()
        {
            var schedulesOutcome = this.raceAdapter.GetSchedules();

            return schedulesOutcome;
        }

        public OperationOutcome Ping()
        {
            return OperationOutcome.Success;
        }
    }
}
