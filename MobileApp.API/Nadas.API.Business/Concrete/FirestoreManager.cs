using Google.Cloud.Firestore;
using Nadas.API.Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nadas.API.Business.Concrete
{
    public class FirestoreManager : IFirestoreService
    {
        private readonly FirestoreDb _db;
        public FirestoreManager()
        {
            string path = path = Path.Combine(Directory.GetCurrentDirectory(), @"Configurations\firestore_config.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", path);
            _db = FirestoreDb.Create("nadas-3dbf2");
        }
        public async Task<string> GetUserInfo(int id)
        {
            CollectionReference collection = _db.Collection("User");
            Query query = collection.WhereEqualTo("id", id);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();
            var snap = querySnapshot.Documents[0];
            if (snap != null)
            {
                string docId = snap.Id;
                DocumentReference doc = _db.Collection("User").Document(docId);
                DocumentSnapshot docSnap = await doc.GetSnapshotAsync();
                if (docSnap != null)
                {
                    Dictionary<string, object> data = docSnap.ToDictionary();
                    string token = data["registrationToken"].ToString();
                    return token;
                }
            }
            return null;
        }
    }
}
