using Firebase.Database;
using Firebase.Database.Query;
using Outline.Models;
using System.Threading.Tasks;

namespace Outline.Helper
{
    class FirebasePointHelper
    {
        readonly FirebaseClient firebaseClient = new FirebaseClient("https://outline-a825f-default-rtdb.firebaseio.com/");
        public async Task AddNgo(string UID, string address)
        {
            await firebaseClient.Child(UID).PostAsync(new NGO()
            {
                Address=address
            }) ;
        }
    }
}
