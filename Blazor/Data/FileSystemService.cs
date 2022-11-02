using MongoDB.Driver;
using MongoDB.Driver.GridFS;

namespace Blazor.Data
{
    public class FileSystemService
    {
        public void UploadImageToDb()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("Images");
            var gridFS = new GridFSBucket(database);

            using (FileStream fs = new FileStream("C://Users/vnsxd/Desktop/image3.jpg", FileMode.Open))
            {
                gridFS.UploadFromStream("Img.jpg", fs);
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
