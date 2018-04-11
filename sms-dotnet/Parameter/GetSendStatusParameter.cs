using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class GetSendStatusParameter : HttpServiceParameter
    {
        /// <summary>
        /// 使用者帳號。SmGateway資料庫表格SMUser中需有此使用者，且狀態為啟用。
        /// </summary>
        [HttpProperty("username", HttpPropertyFor.GET)]
        public string UserName { get; set; }

        /// <summary>
        /// 使用者密碼
        /// </summary>
        [HttpProperty("password", HttpPropertyFor.GET)]
        public string Password { get; set; }

        /// <summary>
        /// 欲查詢的 MessageId 清單
        /// </summary>
        [HttpProperty("msgid", HttpPropertyFor.GET, typeof(MessageIdListToQueryStringParameterConverter))]
        public List<string> MessaegIds { get; set; } = new List<string>();
    }
}
