using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Mitake
{
    public class GetSendStatusResult
    {
        public string MessageId { get; set; }

        public MessageSendStaus Status { get; set; }

        /// <summary>
        /// 狀態更新的時間
        /// </summary>
        public DateTime Time { get; set; }
    }
}
