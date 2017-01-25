using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Services {
    public interface ILauncherService {
        void SendEmail(string subject, string emailText);
        void SendEmail(string to);
        void DialPhoneNumber(string name, string phoneNumber);
        Task<string> LaunchCamera(string fileName);
    }
}
