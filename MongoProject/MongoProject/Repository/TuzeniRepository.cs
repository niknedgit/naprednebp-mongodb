using MongoDB.Bson;
using MongoDB.Driver;
using MongoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Repository
{
    public class TuzeniRepository
    {
            protected DatabaseContext _context;

            public TuzeniRepository(DatabaseContext context)
            {
                _context = context;
            }

            public TuzeniModel Add(string predmetId, TuzeniModel tuzeni)
            {
                tuzeni.Id = ObjectId.GenerateNewId().ToString();
                var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
                var update = Builders<PredmetModel>.Update.Set(_predmet => _predmet.Tuzeni, tuzeni);
                _context.Predmet.UpdateOne(filter, update);
                return tuzeni;
             }

            public TuzeniModel Get(string predmetId)
            {
                var predmet = _context.Predmet.Find(x => x.Id.Equals(predmetId)).FirstOrDefault();
                return predmet.Tuzeni;
            }
        }
}
