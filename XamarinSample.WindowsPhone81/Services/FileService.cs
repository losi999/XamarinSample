using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using XamarinSample.Core.Services;

namespace XamarinSample.WindowsPhone8.Services {
    public class FileService : IFileService {
        public async Task Write(string fileName, string content) {
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(file, content);
        }
    }
}
