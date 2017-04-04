
namespace Spike.Adapters
{
    using System;
    using Spike.Adapters.Contracts;
    using Spike.Commons;
    using Spike.Contracts;
    using System.Data.SqlClient;
    using System.Configuration;
    using System.Collections.Generic;
    public class RaceAdapters : IRaceAdapters
    {
        public DataResponse<Schedules> GetSchedules()
        {
            throw new NotImplementedException();
        }
    }
}
