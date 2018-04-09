using System;
using System.Collections.Generic;
using System.Text;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class MultiMessageParameter : MessageParameter
    {
        [HttpRawStringProperty]
        internal string FormatedMessages
        {
            get
            {
                return ConvertMessagesToFormatedMessages(this);
            }
        }

        public List<SMSMessage> Messages { get; } = new List<SMSMessage>();

        internal static string ConvertMessagesToFormatedMessages(MultiMessageParameter parameter)
        {
            if (parameter.Messages.Count == 0)
            {
                return string.Empty;
            }

            var sb = new StringBuilder();
            for (int i = 0; i < parameter.Messages.Count; i++)
            {
                sb.AppendLine($"[{i.ToString()}]");
                sb.AppendLine(parameter.Messages[i].ToIniString());
            }
            return sb.ToString();
        }
    }
}
