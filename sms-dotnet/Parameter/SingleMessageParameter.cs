using System;
using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public class SingleMessageParameter : MessageParameter, IRequestMessage
    {
        [HttpProperty("dstaddr", HttpPropertyFor.GET)]
        public string DestinationPhoneNumber { get; set; }

        [HttpProperty("DestName", HttpPropertyFor.GET)]
        public string DestinationName { get; set; }

        [HttpProperty("dlvtime", HttpPropertyFor.GET)]
        public DateTime? DesiredDeliverTime { get; set; }

        [HttpProperty("vldtime", HttpPropertyFor.GET, typeof(ValidDurationServiceParameterConverter))]
        public TimeSpan ValidDuration { get; set; }

        [HttpProperty("smbody", HttpPropertyFor.GET)]
        public string Body { get; set; }

        [HttpProperty("response", HttpPropertyFor.GET)]
        public string ResponseUrl { get; set; }

        [HttpProperty("ClientID", HttpPropertyFor.GET)]
        public string ClientID { get; set; }
    }
}
