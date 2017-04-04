

namespace Spike.Adapters.Contracts
{
    using Spike.Commons;
    using Spike.Contracts;
    public interface IRaceAdapters
    {
        DataResponse<Schedules> GetSchedules();
    }
}
