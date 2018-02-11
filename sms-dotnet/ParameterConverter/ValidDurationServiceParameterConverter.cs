using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class ValidDurationServiceParameterConverter : IServiceParameterConveter
    {
        private const int maxValidHours = 24;

        public string Convert(object value)
        {
            var duration = value as TimeSpan?;
            if (duration.HasValue == false)
            {
                return DateTime.Now.Add(TimeSpan.FromHours(maxValidHours)).ToString("yyyyMMddHHmmss");
            }
            
            if (duration.Value.TotalHours >= maxValidHours)
            {
                duration = TimeSpan.FromHours(maxValidHours);
            }

            return DateTime.Now.Add(duration.Value).ToString("yyyyMMddHHmmss");
        }
    }
}
