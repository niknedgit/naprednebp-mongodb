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
    public class UplataRepository
    {
        protected DatabaseContext _context;

        public UplataRepository(DatabaseContext context)
        {
            _context = context;
        }

        public UplataModel Add(string predmetId, UplataModel uplata)
        {
            uplata.Id = ObjectId.GenerateNewId().ToString();
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var update = Builders<PredmetModel>.Update.Push(_predmet => _predmet.Uplate, uplata);
            _context.Predmet.UpdateOne(filter, update);
            return uplata;
          
        }
        public void Update(string predmetId, string uplataId, bool placeno)
        {
            var filter = Builders<PredmetModel>.Filter.ElemMatch(_predmet => _predmet.Uplate,_uplata=>_uplata.Id.Equals(uplataId));
            var update = Builders<PredmetModel>.Update.Set("Uplate.$.Placeno", placeno);
            _context.Predmet.UpdateOne(filter, update);
        }
        public List<UplataModel> GetAll(string predmetId)
        {
            var predmet = _context.Predmet.Find(x => x.Id.Equals(predmetId)).FirstOrDefault();
            return predmet.Uplate;
        }
        public UplataModel Get(string predmetId, string uplataId)
        {
            var predmet = _context.Predmet.Find(x => x.Id.Equals(predmetId)).FirstOrDefault();
            return predmet.Uplate.Find(x => x.Id.Equals(uplataId));
        }
    }
}
