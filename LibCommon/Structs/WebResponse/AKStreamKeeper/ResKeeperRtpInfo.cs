using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCommon.Structs.WebResponse.AKStreamKeeper
{
    public class ResKeeperRtpInfo
    {
        public List<PortInfo> Ports { get; set; }
        public int UseCount { get; set; }

    }
}
