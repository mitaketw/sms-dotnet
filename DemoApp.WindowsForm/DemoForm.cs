using SMS.Mitake;
using System;
using System.Windows.Forms;

namespace DemoApp.WindowsForm
{
    public partial class DemoForm : Form
    {
        public DemoForm()
        {
            InitializeComponent();
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            var destinationPhoneNumberArray = TextBoxPhoneNumber.Text.Split(';');

            if (destinationPhoneNumberArray.Length == 1)
            {
                var singleParameter = new SingleMessageParameter
                {
                    UserName = TextBoxUserName.Text,
                    Password = TextBoxPassword.Text,
                    DestinationPhoneNumber = TextBoxPhoneNumber.Text,
                    Body = TextBoxBody.Text,
                    Encoding = MessageBodyEncoding.UTF8,
                };
                var singleService = new SingleMessageService();
                var singleResult = await singleService.InvokeAsync(singleParameter);
            }
            else
            {
                var multiParameter = new MultiMessageParameter()
                {
                    UserName = TextBoxUserName.Text,
                    Password = TextBoxPassword.Text,
                    Encoding = MessageBodyEncoding.UTF8,
                };

                for (int i = 0; i < destinationPhoneNumberArray.Length; i++)
                {
                    multiParameter.Messages.Add(new SMSMessage
                    {
                        DestinationPhoneNumber = destinationPhoneNumberArray[i],
                        Body = $"{TextBoxBody.Text}{i}",
                    });
                }

                var multiService = new MultiMessageService();
                var multiResult = await multiService.InvokeAsync(multiParameter);
            }
        }
    }
}
