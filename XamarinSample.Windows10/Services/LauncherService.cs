using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Email;
using Windows.Media.Capture;
using Windows.Storage;
using XamarinSample.Core.Services;

namespace XamarinSample.Windows10.Services {
    public class LauncherService : ILauncherService {
        private IFileService _file;

        public LauncherService(IFileService file) {
            _file = file;
        }

        public async void DialPhoneNumber(string name, string phoneNumber) {
            PhoneCallStore phoneCallStore = await PhoneCallManager.RequestStoreAsync();
            Guid lineId = await phoneCallStore.GetDefaultLineAsync();
            PhoneLine line = await PhoneLine.FromIdAsync(lineId);
            line.Dial(phoneNumber, name);
        }

        public async Task<string> LaunchCamera(string fileName) {
            CameraCaptureUI captureUI = new CameraCaptureUI();
            captureUI.PhotoSettings.Format = CameraCaptureUIPhotoFormat.Jpeg;

            StorageFile photo = await captureUI.CaptureFileAsync(CameraCaptureUIMode.Photo);

            if (photo != null) {
                var fullPath = await _file.Copy(photo.Path, fileName);
                await photo.DeleteAsync();
                return fullPath;
            }

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
