using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class MultiMessageService : BaseHttpService<List<MessageSendResult>, MultiMessageParameter, MultiMessageParser>
    {
        protected override string CreateRequestUri(MultiMessageParameter parameter)
        {
            return "http://smexpress.mitake.com.tw/SmSendPost.asp";
        }
    }
}
