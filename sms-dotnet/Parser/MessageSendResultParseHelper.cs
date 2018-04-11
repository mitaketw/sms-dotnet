using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SMS.Mitake
{
    public static class MessageSendResultParseHelper
    {
        public static List<MessageSendResult> Parse(StreamReader sr)
        {
            var result = new List<MessageSendResult>();
            MessageSendResult messageSendResult = null;

            while (sr.EndOfStream == false)
            {
                var line = sr.ReadLine();

                if (line.StartsWith("[", StringComparison.CurrentCultureIgnoreCase))
                {
                    messageSendResult = new MessageSendResult();
                    result.Add(messageSendResult);
                    continue;
                }

                var segements = line.Split('=');
                if (segements.Length < 2)
                {
                    continue;
                }

                if (string.Compare("msgid", segements[0], StringComparison.OrdinalIgnoreCase) == 0)
                {
                    messageSendResult.MessageId = segements[1];
                    continue;
                }

                if (string.Compare("statuscode", segements[0], StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    messageSendResult.Status = ParseStatus(segements[1]);
                    continue;
                }

                if (string.Compare("AccountPoint", segements[0], StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    int.TryParse(segements[1], out var accountPoint);
                    messageSendResult.AccountPoint = accountPoint;
                    continue;
                }

                if (string.Compare("Duplicate", segements[0], StringComparison.CurrentCultureIgnoreCase) == 0)
                {
                    messageSendResult.Duplicate = (string.Compare(segements[1], "Y", StringComparison.CurrentCultureIgnoreCase) == 0);
                    continue;
                }
            }

            return result;
        }

        public static MessageSendStaus ParseStatus(string source)
        {
            MessageSendStaus result = MessageSendStaus.Success;

            switch (source)
            {
                case "*":
                    result = MessageSendStaus.InternalError;
                    break;
                case "a":
                    result = MessageSendStaus.ServiceUnavailable1;
                    break;
                case "b":
                    result = MessageSendStaus.ServiceUnavailable2;
                    break;
                case "c":
                    result = MessageSendStaus.EmptyUserId;
                    break;
                case "d":
                    result = MessageSendStaus.EmptyUserPassword;
                    break;
                case "e":
                    result = MessageSendStaus.InvalidUserOrPassword;
                    break;
                case "f":
                    result = MessageSendStaus.AccountExpired;
                    break;
                case "h":
                    result = MessageSendStaus.AccountSuspended;
                    break;
                case "k":
                    result = MessageSendStaus.InvalidAddress;
                    break;
                case "m":
                    result = MessageSendStaus.RequiredChangePassword;
                    break;
                case "n":
                    result = MessageSendStaus.PasswordExpired;
                    break;
                case "p":
                    result = MessageSendStaus.NotAuthorized;
                    break;
                case "r":
                    result = MessageSendStaus.ServiceTemporaryUnavaliable;
                    break;
                case "s":
                    result = MessageSendStaus.AccountError;
                    break;
                case "t":
                    result = MessageSendStaus.MessageExpired;
                    break;
                case "u":
                    result = MessageSendStaus.MessageBodyIsEmpty;
                    break;
                case "v":
                    result = MessageSendStaus.InvalidPhoneNumber;
                    break;
                case "0":
                    result = MessageSendStaus.Appointed;
                    break;
                case "1":
                    result = MessageSendStaus.AlreadSentToOperator1;
                    break;
                case "2":
                    result = MessageSendStaus.AlreadSentToOperator2;
                    break;
                case "3":
                    result = MessageSendStaus.AlreadSentToOperator3;
                    break;
                case "4":
                    result = MessageSendStaus.AlreadSentToPhone;
                    break;
                case "5":
                    result = MessageSendStaus.MessageBodyError;
                    break;
                case "6":
                    result = MessageSendStaus.PhoneNumberInCorrect;
                    break;
                case "7":
                    result = MessageSendStaus.AccountHasBeenSuspended;
                    break;
                case "8":
                    result = MessageSendStaus.Timeout;
                    break;
                case "9":
                    result = MessageSendStaus.AppointCanceled;
                    break;
            }

            return result;
        }
    }
}
