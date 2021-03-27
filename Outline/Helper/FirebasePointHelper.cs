using Firebase.Database;
using Firebase.Database.Query;

namespace Outline.Helper
{
    class FirebasePointHelper
    {
        readonly FirebaseClient forenaseClinet = new FirebaseClient("https://outline-a825f-default-rtdb.firebaseio.com/");
        private readonly string pointType = "PeopleRegistered";
    }
}
