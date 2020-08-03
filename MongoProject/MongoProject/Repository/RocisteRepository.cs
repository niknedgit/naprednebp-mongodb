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
    public class RocisteRepository
    {

        protected DatabaseContext _context;

        public RocisteRepository(DatabaseContext context)
        {
            _context = context;
        }

        public RocisteModel Add( RocisteModel rociste)
        {
            _context.Rociste.InsertOne(rociste);
            return rociste;
        }
        public List<RocisteModel> Get()
        {
            List<RocisteModel> SvaRocista=_context.Rociste.Find(_=>true).ToList();
            List<RocisteModel> rocista=new List<RocisteModel>();
            foreach(RocisteModel rociste in SvaRocista)
                if (DateTime.Parse(rociste.Datum).CompareTo(DateTime.Now) > 0)
                    rocista.Add(rociste);  
            
            return rocista;
        }
        public void Delete(string predmetId)
        {
            var deleteFilter = Builders<RocisteModel>.Filter.Eq("PredmetId", predmetId);
            _context.Rociste.DeleteMany(deleteFilter);
        }

    }
}
