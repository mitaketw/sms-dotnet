using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Unicorn.Net;

namespace SMS.Mitake
{
    public class SingleMessageParser : BaseParser<MessageSendResult, HttpResponseMessage>
    {
        public override async Task<ParseResult<MessageSendResult>> Parse(HttpResponseMessage source)
        {
            if (source.IsSuccessStatusCode == false)
            {
                return new ParseResult<MessageSendResult>(new ParseError(source.StatusCode.ToString()));
            }

            var contentStream = await source.Content.ReadAsStreamAsync();
            using (var sr = new StreamReader(contentStream, Encoding.ASCII))
            {
                var result = MessageSendResultParseHelper.Parse(sr);
                var messageResult = result.FirstOrDefault();
                if (messageResult == null)
                {
                    return new ParseResult<MessageSendResult>(new ParseError("wrong content"));
                }

                return new ParseResult<MessageSendResult>(messageResult);
            }
        }
    }
}
