using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using XamarinSample.Core.Services;

namespace XamarinSample.WindowsPhone81.Services {
    public class FileService : IFileService {
        public Task<string> Copy(string source, string destination) {
            throw new NotImplementedException();
        }

        public Task Delete(string photoPath) {
            throw new NotImplementedException();
        }

        public async Task Write(string fileName, string content) {
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(file, content);
        }
    }
}
