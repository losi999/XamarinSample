using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using XamarinSample.Core.Services;

namespace XamarinSample.iOS.Services {
    public class FileService : IFileService {
        public Task<string> Copy(string source, string destination) {
            throw new NotImplementedException();
        }

        public Task Delete(string photoPath) {
            throw new NotImplementedException();
        }

        public async Task Write(string fileName, string content) {
            //throw new NotImplementedException();
        }
    }
}
