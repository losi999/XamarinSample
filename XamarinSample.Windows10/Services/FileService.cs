using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using XamarinSample.Core.Services;

namespace XamarinSample.Windows10.Services {
    public class FileService : IFileService {
        public async Task<string> Copy(string source, string destination) {
            StorageFile sourceFile = await StorageFile.GetFileFromPathAsync(source);

            var destinationFile = await sourceFile.CopyAsync(ApplicationData.Current.LocalFolder, destination + sourceFile.FileType, NameCollisionOption.ReplaceExisting);

            return destinationFile.Path;
        }

        public async Task Delete(string absolutePath) {
            StorageFile sourceFile = await StorageFile.GetFileFromPathAsync(absolutePath);
            await sourceFile.DeleteAsync();
        }

        public async Task Write(string fileName, string content) {
            StorageFolder folder = ApplicationData.Current.LocalFolder;
            StorageFile file = await folder.CreateFileAsync(fileName, CreationCollisionOption.ReplaceExisting);

            await FileIO.WriteTextAsync(file, content);
        }
    }
}
