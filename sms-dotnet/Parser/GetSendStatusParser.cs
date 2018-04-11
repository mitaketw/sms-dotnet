using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Unicorn.Net;

namespace SMS.Mitake
{
    public class GetSendStatusParser : BaseParser<List<GetSendStatusResult>, HttpResponseMessage>
    {
        public override async Task<ParseResult<List<GetSendStatusResult>>> Parse(HttpResponseMessage source)
        {
            if (source.IsSuccessStatusCode == false)
            {
                return new ParseResult<List<GetSendStatusResult>>(new ParseError(source.StatusCode.ToString()));
            }

            var contentStream = await source.Content.ReadAsStreamAsync();
            using (var sr = new StreamReader(contentStream, Encoding.ASCII))
            {
                var result = new List<GetSendStatusResult>();

                while (sr.EndOfStream == false)
                {
                    var line = sr.ReadLine();
                    var segements = line.Split('\t');

                    if (segements.Length < 3)
                    {
                        continue;
                    }

                    result.Add(new GetSendStatusResult
                    {
                        MessageId = segements[0],
                        Status = MessageSendResultParseHelper.ParseStatus(segements[1]),
                        Time = DateTime.Parse(segements[2]),
                    });
                }

                return new ParseResult<List<GetSendStatusResult>>(result);
            }
        }
    }
}
