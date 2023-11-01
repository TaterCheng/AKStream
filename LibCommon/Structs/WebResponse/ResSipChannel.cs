using LibCommon.Structs.DBModels;
using LibCommon.Structs.GB28181;
using LibCommon.Structs.WebRequest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCommon.Structs.WebResponse
{
    public class ResSipChannel
    {
        private ReqSipChannel? _request;
        private long? _total;
        private List<SipChannel>? _sipChannelList;

        /// <summary>
        /// 音视频通道实例列表
        /// </summary>
        public List<SipChannel>? SipChannelList
        {
            get => _sipChannelList;
            set => _sipChannelList = value;
        }

        /// <summary>
        /// 请求结构
        /// </summary>
        public ReqSipChannel? Request
        {
            get => _request;
            set => _request = value;
        }

        /// <summary>
        /// 总数
        /// </summary>
        public long? Total
        {
            get => _total;
            set => _total = value;
        }
    }
}
