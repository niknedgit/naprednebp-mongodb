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
    public class AdvokatRepository
    {
        protected DatabaseContext _context;

        public AdvokatRepository(DatabaseContext context)
        {
            _context = context;
        }

        public AdvokatModel DodajAdvokataTuzenom(string predmetId, AdvokatModel advokat)
        {
            advokat.Id = ObjectId.GenerateNewId().ToString();
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var update = Builders<PredmetModel>.Update.Set("Tuzeni.Advokat", advokat);       
            _context.Predmet.UpdateOne(filter, update);
         
            return advokat;
        }
        public AdvokatModel DodajAdvokataTuziocu(string predmetId, AdvokatModel advokat)
        {
            advokat.Id = ObjectId.GenerateNewId().ToString();
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var update = Builders<PredmetModel>.Update.Set("Tuzilac.Advokat", advokat);
            _context.Predmet.UpdateOne(filter, update);

            return advokat;
        }
        public AdvokatModel VratiAdvokataTuzioca(string predmetId)
        {
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var predmet = _context.Predmet
                                         .Find(filter)
                                         .FirstOrDefault();

            return predmet.Tuzilac.Advokat;
        }
        public AdvokatModel VratiAdvokataTuzenog(string predmetId)
        {
            var filter = Builders<PredmetModel>.Filter.Eq(_predmet => _predmet.Id, predmetId);
            var predmet = _context.Predmet
                                         .Find(filter)
                                         .FirstOrDefault();

            return predmet.Tuzeni.Advokat;

        }
    }
}
