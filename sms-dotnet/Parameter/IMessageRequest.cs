using System;
using System.Collections.Generic;
using System.Text;

namespace SMS.Mitake
{
    public interface IRequestMessage
    {
        /// <summary>
        /// 受訊方手機號碼。請填入09帶頭的手機號碼。
        /// </summary>
        string DestinationPhoneNumber { get; set; }

        /// <summary>
        /// 收訊人名稱。若其他系統需要與簡訊資料進行系統整合，此欄位可填入來源系統所產生的Key值，以對應回來源資料庫。
        /// </summary>
        string DestinationName { get; set; }

        /// <summary>
        /// <para>簡訊預約時間。也就是希望簡訊何時送達手機，格式為YYYY-MM-DD HH:NN:SS或YYYYMMDDHHNNSS，或是整數值代表幾秒後傳送。</para>
        /// <para>若預約時間大於系統時間，則為預約簡訊，預約時間離目前時間若預約時間已過或為空白則為即時簡訊。即時簡訊為儘早送出，若受到MsgType宵禁欄位的限制，就不一定是立刻送出。</para>
        /// </summary>
        DateTime? DesiredDeliverTime { get; set; }

        /// <summary>
        /// <para>簡訊有效期限。格式為YYYY-MM-DD HH:NN:SS或YYYYMMDDHHNNSS，或是整數值代表傳送後幾秒後內有效。</para>
        /// <para>請勿超過大哥大業者預設之24小時期限，以避免業者不回覆簡訊狀態。</para>
        /// </summary>
        TimeSpan? ValidDuration { get; set; }

        /// <summary>
        /// <para>簡訊內容。必須為BIG-5編碼，長度70個中文字或是160個英數字。若有換行的需求，請填入ASCII Code 6代表換行。為避免訊息中有&電文分隔符號，請將此欄位進行url encode。</para>
        /// <para>url encode時，空白可用%20或維持空白即可，請勿將空白encode為+號。若對url encode有任何的相容性疑慮，建議使用%FF的方式將參數內容全部編碼即可。</para>
        /// </summary>
        string Body { get; set; }

        /// <summary>
        /// <para>狀態回報網址。會帶回資訊如下</para>
        /// <para>msgid=三竹簡訊序號&dstaddr=手機門號&dlvtime=發送時間&donetime=狀態時間&statusstr=狀態字串&statuscode=0&StatusFlag=最新簡訊狀態</para>
        /// </summary>
        string ResponseUrl { get; set; }

        /// <summary>
        /// <para>客戶簡訊ID。用於避免重複發送，若有提供此參數，則會判斷該簡訊ID是否曾經發送，若曾發送過，則直接回覆之前發送的回覆值，並加上Duplicate=Y。</para>
        /// <para>這個檢查機制只留存12小時內的資料，12小時候後重複的ClientID”可能”會被當成新簡訊。此外，ClientID必須維持唯一性，而非只在12小時內唯一，建議可使用GUID來保證其唯一性。</para>
        /// </summary>
        string ClientID { get; set; }
    }
}
