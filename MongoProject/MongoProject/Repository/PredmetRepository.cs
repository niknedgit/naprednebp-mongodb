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
    public class PredmetRepository
    {
        protected DatabaseContext _context;

        public PredmetRepository(DatabaseContext context)
        {
            _context = context;
        }

        public PredmetModel Add(PredmetModel predmet)
        {
            _context.Predmet.InsertOne(predmet);
            return predmet;
        }

        public PredmetModel Get(string predmetId)
        {
            var predmet =  _context.Predmet.Find(i => i.Id.Equals(predmetId));
            return predmet.FirstOrDefault();
        }
        public List<PredmetModel> GetAll()
        {
            var predmeti = _context.Predmet.Find(_=>true); 
            return predmeti.ToList();
        }
        public PredmetModel Find(string brPredmeta)
        {
            var predmet = _context.Predmet.Find(i => i.BrPredmeta.Equals(brPredmeta));
            return predmet.FirstOrDefault();
        }
        public void Delete(string brPredmeta)
        {
            var deleteFilterPredmet = Builders<PredmetModel>.Filter.Eq("BrPredmeta", brPredmeta);
            _context.Predmet.DeleteOne(deleteFilterPredmet);
        }
    }
}
