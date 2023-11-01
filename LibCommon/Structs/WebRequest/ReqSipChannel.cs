using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCommon.Structs.WebRequest
{
    public class ReqSipChannel : ReqPaginationBase
    {
        public string deviceId { get; set; }
    }
}
