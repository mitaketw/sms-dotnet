using System;
using System.Text;

namespace SMS.Mitake
{
    public class SMSMessage : ISMSMessage
    {
        public string DestinationPhoneNumber { get; set; }

        public string DestinationName { get; set; }

        public DateTime? DesiredDeliverTime { get; set; }

        public TimeSpan? ValidDuration { get; set; }

        public string Body { get; set; }

        public string ResponseUrl { get; set; }

        public string ClientID { get; set; }
    }

    internal static class SMSMessageExtension
    {
        private static DateTimeServiceParameterConverter _dateTimeServiceParameterConverter = new DateTimeServiceParameterConverter();
        private static ValidDurationServiceParameterConverter _validDurationServiceParameterConverter = new ValidDurationServiceParameterConverter();

        public static string ToIniString(this SMSMessage smsMessage)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"dstaddr={smsMessage.DestinationPhoneNumber}");
            sb.AppendLine($"DestName={smsMessage.DestinationName}");
            sb.AppendLine($"dlvtime={_dateTimeServiceParameterConverter.Convert(smsMessage.DesiredDeliverTime)}");
            sb.AppendLine($"vldtime={_validDurationServiceParameterConverter.Convert(smsMessage.ValidDuration)}");
            sb.AppendLine($"smbody={smsMessage.Body}");
            sb.AppendLine($"response={smsMessage.ResponseUrl}");
            sb.AppendLine($"ClientID={smsMessage.ClientID}");
            return sb.ToString();
        }
    }
}
