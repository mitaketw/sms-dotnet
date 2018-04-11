using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class GetSendStatusService : BaseHttpService<List<GetSendStatusResult>, GetSendStatusParameter, GetSendStatusParser>
    {
        protected override string CreateRequestUri(GetSendStatusParameter parameter)
        {
            return "http://smexpress.mitake.com.tw/SmQueryGet.asp";
        }
    }
}
