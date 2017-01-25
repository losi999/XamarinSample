using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;

namespace XamarinSample.iOS.Services {
    public class LauncherService : ILauncherService {
        public void DialPhoneNumber(string name, string phoneNumber) {
            throw new NotImplementedException();
        }

        public Task<string> LaunchCamera(string fileName) {
            throw new NotImplementedException();
        }

        public void SendEmail(string to) {
            throw new NotImplementedException();
        }

        public void SendEmail(string subjec, string emailText) {
            throw new NotImplementedException();
        }
    }
}
