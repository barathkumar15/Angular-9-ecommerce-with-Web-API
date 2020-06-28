using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.DataModel
{
    public class ErrorModel
    {
        public ErrorModel(string message)
        {
            this.Message = message;
        }

        public string Message { get; private set; }
    }
}
