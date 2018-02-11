using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class SingleMessageService : BaseHttpService<MessageSendResult, SingleMessageParameter, SingleMessageParser>
    {
        protected override string CreateRequestUri(SingleMessageParameter parameter)
        {
            return "https://smexpress.mitake.com.tw/SmSendGet.asp";
        }
    }
}
