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
    public class PredmetRocisteRepository
    {
        protected DatabaseContext _context;

        public PredmetRocisteRepository(DatabaseContext context)
        {
            _context = context;
        }

        public PredmetRocisteModel Add(string predmetId, PredmetRocisteModel rociste)
        {
            rociste.Id = ObjectId.GenerateNewId().ToString();
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var update = Builders<PredmetModel>.Update.Push(_predmet => _predmet.Rocista, rociste);
            _context.Predmet.UpdateOne(filter, update);
            return rociste;

        }
        public List<PredmetRocisteModel> GetAll(string predmetId)
        {
            var predmet = _context.Predmet.Find(x => x.Id.Equals(predmetId)).FirstOrDefault();
            return predmet.Rocista;
        }
    
    }
}
