using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class DateTimeServiceParameterConverter : IServiceParameterConveter
    {
        public string Convert(object value)
        {
            var dateTime = value as DateTime?;
            if (dateTime.HasValue)
            {
                return dateTime.Value.ToString("yyyyMMddHHmmss");
            }

            return string.Empty;
        }
    }
}
