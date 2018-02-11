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
            var parameter = new SingleMessageParameter
            {
                UserName = TextBoxUserName.Text,
                Password = TextBoxPassword.Text,
                DestinationPhoneNumber = TextBoxPhoneNumber.Text,
                Body = TextBoxBody.Text,
                Encoding = MessageBodyEncoding.UTF8,
            };
            var service = new SingleMessageService();
            var result = await service.InvokeAsync(parameter);
        }
    }
}
