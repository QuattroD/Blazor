using MongoDB.Driver;

namespace Blazor.Data
{
    public class UserService
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase database = client.GetDatabase("PersonalAccounts");
        static IMongoCollection<AutorizationModel> collection = database.GetCollection<AutorizationModel>("Users");
        public void SignUp(AutorizationModel user)
        {          
            var MyUser = collection.Find(x => x._id == user._id).FirstOrDefault();
            if (MyUser == null)
            {
                collection.InsertOne(user);
            }
        }
    }
}
