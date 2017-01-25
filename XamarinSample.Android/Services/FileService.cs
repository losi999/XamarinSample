using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinSample.Core.Services;
using System.IO;
using System;

namespace XamarinSample.Android.Services {
    public class FileService : IFileService {
        public Task<string> Copy(string source, string destination) {
            throw new NotImplementedException();
        }

        public async Task Delete(string photoPath) {
            var file = new Java.IO.File(photoPath);
            file.Delete();
        }

        public Task Write(string fileName, string content) {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string settingsPath = Path.Combine(path, fileName);
            StreamWriter stream = File.CreateText(settingsPath);
            stream.Write(content);
            stream.Close();

            return null;
        }
    }
}