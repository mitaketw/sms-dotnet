using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Unicorn.Net;

namespace SMS.Mitake
{
    public class MultiMessageParser : BaseParser<List<MessageSendResult>, HttpResponseMessage>
    {
        public override async Task<ParseResult<List<MessageSendResult>>> Parse(HttpResponseMessage source)
        {
            if (source.IsSuccessStatusCode == false)
            {
                return new ParseResult<List<MessageSendResult>>(new ParseError(source.StatusCode.ToString()));
            }

            var contentStream = await source.Content.ReadAsStreamAsync();
            using (var sr = new StreamReader(contentStream, Encoding.ASCII))
            {
                var result = MessageSendResultParseHelper.Parse(sr);
                return new ParseResult<List<MessageSendResult>>(result);
            }
        }
    }
}
