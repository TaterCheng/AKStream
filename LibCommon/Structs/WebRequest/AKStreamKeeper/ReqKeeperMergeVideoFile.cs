using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibCommon.Structs.WebRequest.AKStreamKeeper
{
    public class ReqKeeperMergeVideoFile
    {
        private List<string> _files;
        private string _outputName;
        private string? _app;
        private string? _callbackUrl;
        private string? _mainId;
        private string? _mediaServerId;
        private string? _vhost;

        public List<string> Files
        {
            get => _files;
            set => _files = value;
        }

        public string OutputName
        {
            get => _outputName;
            set => _outputName = value;
        }

        public string? MediaServerId
        {
            get => _mediaServerId;
            set => _mediaServerId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string? App
        {
            get => _app;
            set => _app = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string? Vhost
        {
            get => _vhost;
            set => _vhost = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string? MainId
        {
            get => _mainId;
            set => _mainId = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public string? CallbackUrl
        {
            get => _callbackUrl;
            set => _callbackUrl = value;
        }
    }
}
