using System.IO;
using System.Threading.Tasks;

namespace UploadFilesServer.Services
{
    public interface IUploadService
    {
        Task<string> UploadAsync(Stream fileStream, string fileName, string contentType);
    }
}