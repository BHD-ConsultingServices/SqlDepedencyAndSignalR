using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spike.Contracts
{
    using Spike.Commons; 
    
    public interface IRaceOrchestrations
    {
        DataResponse<Schedules> GetSchedules();

        OperationOutcome Ping();
    }
}
