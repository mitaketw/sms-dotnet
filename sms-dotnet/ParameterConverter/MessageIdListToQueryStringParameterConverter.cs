using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class MessageIdListToQueryStringParameterConverter : IServiceParameterConveter
    {
        public string Convert(object value)
        {
            var messageIds = value as List<string>;
            if (messageIds.Count == 0)
            {
                return string.Empty;
            }

            return string.Join(",", messageIds);
        }
    }
}
