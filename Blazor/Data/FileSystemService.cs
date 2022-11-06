using Microsoft.AspNetCore.Components.Forms;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Blazor.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(IBrowserFile files, string path)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Files");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                gridFS.UploadFromStream(files.Name, fs);
            }
        }

        public void DownloadToLocal()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images");
            var gridFS = new GridFSBucket(database);
            using (FileStream fs = new FileStream($"{Directory.CreateDirectory(Directory.GetCurrentDirectory() + "/Images/")}DeserializedImage.jpg", FileMode.CreateNew))
            {
                gridFS.DownloadToStreamByName("Img.jpg", fs);
            }
        }
    }
}
