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
            if (value is TimeSpan duration)
            {
                if (duration.TotalHours >= maxValidHours)
                {
                    duration = TimeSpan.FromHours(maxValidHours);
                }

                return DateTime.Now.Add(duration).ToString("yyyyMMddHHmmss");
            }

            return DateTime.Now.Add(TimeSpan.FromHours(maxValidHours)).ToString("yyyyMMddHHmmss");
        }
    }
}
