using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System.IO;
using Microsoft.AspNetCore.Components.Forms;

namespace Blazor.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb(IBrowserFile file)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("File");
            var gridFS = new GridFSBucket(database);
            Stream stream = file.OpenReadStream();
            gridFS.UploadFromStream(file.Name, stream);
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
