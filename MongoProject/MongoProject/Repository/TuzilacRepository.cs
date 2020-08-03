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
    public class TuzilacRepository
    {
        protected DatabaseContext _context;

        public TuzilacRepository(DatabaseContext context)
        {
            _context = context;
        }

        public TuzilacModel Add(string predmetId, TuzilacModel tuzilac)
        {
            tuzilac.Id = ObjectId.GenerateNewId().ToString();
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var update = Builders<PredmetModel>.Update.Set(_predmet => _predmet.Tuzilac, tuzilac);
            _context.Predmet.UpdateOne(filter, update);
            return tuzilac;
        }

        public TuzilacModel Get(string predmetId)
        {
            var predmet = _context.Predmet.Find(x => x.Id.Equals(predmetId)).FirstOrDefault();
            return predmet.Tuzilac;
        }
    }
}
