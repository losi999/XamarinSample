using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Email;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using Windows.Storage;
using XamarinSample.Core.Services;


namespace XamarinSample.WindowsPhone81.Services {
    public class LauncherService : ILauncherService {
        public void DialPhoneNumber(string name, string phoneNumber) {
            PhoneCallManager.ShowPhoneCallUI(phoneNumber, name);
        }

        public async Task<string> LaunchCamera(string fileName) {

            return "";
        }

        public async void SendEmail(string to) {
            var emailMessage = new EmailMessage();
            emailMessage.To.Add(new EmailRecipient(to));

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }

        public async void SendEmail(string subject, string emailText) {
            var emailMessage = new EmailMessage();
            emailMessage.Body = emailText;
            emailMessage.Subject = subject;

            await EmailManager.ShowComposeNewEmailAsync(emailMessage);
        }
    }
}
