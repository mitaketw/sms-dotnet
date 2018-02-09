using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class EnumToStringServiceParameterConverter : IServiceParameterConveter
    {
        public string Convert(object value)
        {
            if (value is MessageSendStaus messageSendStatus)
            {
                return messageSendStatus.ToString();
            }

            return string.Empty;
        }
    }
}
