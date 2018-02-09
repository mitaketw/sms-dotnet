namespace SMS.Mitake
{
    public enum MessageSendStaus
    {
        Success,
        /// <summary>
        /// 系統發生錯誤，請聯絡三竹資訊窗口人員
        /// </summary>
        InternalError,
        /// <summary>
        /// 簡訊發送功能暫時停止服務，請稍候再試
        /// </summary>
        ServiceUnavailable1,
        /// <summary>
        /// 簡訊發送功能暫時停止服務，請稍候再試
        /// </summary>
        ServiceUnavailable2,
        /// <summary>
        /// 請輸入帳號
        /// </summary>
        EmptyUserId,
        /// <summary>
        /// 請輸入密碼
        /// </summary>
        EmptyUserPassword,
        /// <summary>
        /// 帳號、密碼錯誤
        /// </summary>
        InvalidUserOrPassword,
        /// <summary>
        /// 帳號已過期
        /// </summary>
        AccountExpired,
        /// <summary>
        /// 帳號已被停用
        /// </summary>
        AccountSuspended,
        /// <summary>
        /// 無效的連線位址
        /// </summary>
        InvalidAddress,
        /// <summary>
        /// 必須變更密碼，在變更密碼前，無法使用簡訊發送服務
        /// </summary>
        RequiredChangePassword,
        /// <summary>
        /// 密碼已逾期，在變更密碼前，將無法使用簡訊發送服務
        /// </summary>
        PasswordExpired,
        /// <summary>
        /// 沒有權限使用外部Http程式
        /// </summary>
        NotAuthorized,
        /// <summary>
        /// 系統暫停服務，請稍後再試
        /// </summary>
        ServiceTemporaryUnavaliable,
        /// <summary>
        /// 帳務處理失敗，無法發送簡訊
        /// </summary>
        AccountError,
        /// <summary>
        /// 簡訊已過期
        /// </summary>
        MessageExpired,
        /// <summary>
        /// 簡訊內容不得為空白
        /// </summary>
        MessageBodyIsEmpty,
        /// <summary>
        /// 無效的手機號碼
        /// </summary>
        InvalidPhoneNumber,
        /// <summary>
        /// 預約傳送中
        /// </summary>
        Appointed,
        /// <summary>
        /// 已送達業者
        /// </summary>
        AlreadSentToOperator1,
        /// <summary>
        /// 已送達業者
        /// </summary>
        AlreadSentToOperator2,
        /// <summary>
        /// 已送達業者
        /// </summary>
        AlreadSentToOperator3,
        /// <summary>
        /// 已送達手機
        /// </summary>
        AlreadSentToPhone,
        /// <summary>
        /// 內容有錯誤
        /// </summary>
        MessageBodyError,
        /// <summary>
        /// 門號有錯誤
        /// </summary>
        PhoneNumberInCorrect,
        /// <summary>
        /// 簡訊已停用
        /// </summary>
        AccountHasBeenSuspended,
        /// <summary>
        /// 逾時無送達
        /// </summary>
        Timeout,
        /// <summary>
        /// 預約已取消
        /// </summary>
        AppointCanceled,
    }
}
