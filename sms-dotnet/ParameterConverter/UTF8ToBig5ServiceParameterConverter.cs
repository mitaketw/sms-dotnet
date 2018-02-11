using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class UTF8ToBig5ServiceParameterConverter : IServiceParameterConveter
    {
        public string Convert(object value)
        {
            var sourceEncoding = Encoding.UTF8;
            var destinationEncoding = Encoding.ASCII;

            var sourceString = value as string;
            byte[] sourceStringBytes = null;

            if (string.IsNullOrEmpty(sourceString))
            {
                sourceStringBytes = sourceEncoding.GetBytes(string.Empty);
            }
            else
            {
                sourceStringBytes = sourceEncoding.GetBytes(sourceString);
            }

            var destinationStringBytes = Encoding.Convert(sourceEncoding, destinationEncoding, sourceStringBytes);
            return destinationEncoding.GetString(destinationStringBytes);
        }
    }
}
