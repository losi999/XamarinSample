using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinSample.Core.Services {
    public interface IFileService {
        Task Write(string fileName, string content);
        Task<string> Copy(string source, string destination);
        Task Delete(string photoPath);
    }
}
