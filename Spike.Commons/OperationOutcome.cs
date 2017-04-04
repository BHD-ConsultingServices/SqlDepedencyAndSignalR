using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spike.Commons
{
    public class OperationOutcome
    {
        public bool IsSuccessful { get; set; }

        public string ErrorMessage { get; set; }

        public static OperationOutcome CreateError(string errorMessage)
        {
            return new OperationOutcome { IsSuccessful = false, ErrorMessage = errorMessage };
        }

        public static OperationOutcome Success
        {
            get
            {
                return new OperationOutcome { IsSuccessful = true };
            }
        }
    }
}
