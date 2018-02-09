using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Mitake
{
    public class MessageSendResult
    {
        /// <summary>
        /// <para>簡訊序號。為SmGateway所編定的簡訊序號。</para>
        /// <para>發送後進行查詢或狀態回報，均以此作為Key值。若該筆簡訊發送失敗，則不會有此欄位</para>
        /// </summary>
        public string MessageId { get; set; }

        /// <summary>
        /// 發送狀態
        /// </summary>
        public MessageSendStaus Status { get; set; }

        /// <summary>
        /// 剩餘點數。本次發送後的剩餘額度
        /// </summary>
        public int AccountPoint { get; set; }

        /// <summary>
        /// <para>是否為重複發送的簡訊</para>
        /// <para>Y代表重複發送，其他值或無此欄位代表非重複發送。</para>
        /// </summary>
        public bool Duplicate { get; set; }
    }
}
