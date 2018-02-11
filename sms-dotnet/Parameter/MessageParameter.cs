using Unicorn.ServiceModel;

namespace SMS.Mitake
{
    public abstract class MessageParameter : HttpServiceParameter
    {
        /// <summary>
        /// 使用者帳號。SmGateway資料庫表格SMUser中需有此使用者，且狀態為啟用。
        /// </summary>
        [HttpProperty("username", HttpPropertyFor.GET)]
        public string UserName { get; set; }

        /// <summary>
        /// 使用者密碼
        /// </summary>
        [HttpProperty("password", HttpPropertyFor.GET)]
        public string Password { get; set; }

        /// <summary>
        /// Smbody及DestName的編碼方式
        /// <para>注意事項1：雖然三竹支援客戶指定編碼方式，但這是用於將資料轉成Big5的格式。若送來日文、韓文、簡體中文..等的unicode，保證送出去一定不是所要的結果。</para>
        /// <para>注意事項2：編碼的轉換是透過Window的CodePage做轉換。不保證每一個看起來像繁體中文的Unicode都能完美的對應到Big5的內碼，請測試OK後再上線，轉換結果若有缺陷，只能敬請見諒。</para>
        /// </summary>
        [HttpProperty("encoding", HttpPropertyFor.GET, typeof(EnumToStringServiceParameterConverter))]
        public MessageBodyEncoding Encoding { get; set; } = MessageBodyEncoding.UTF8;
    }
}
