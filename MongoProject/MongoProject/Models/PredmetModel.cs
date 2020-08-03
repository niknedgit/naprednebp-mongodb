using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject.Models
{
    public class PredmetModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Vrsta { get; set; }
        public string Podaci { get; set; }
        public string NazivSuda { get; set; }
        public string Godina { get; set; }
        public string BrPredmeta { get; set; }
        public string Sudija{ get; set; }
        public TuzeniModel Tuzeni { get; set; }
        public TuzilacModel Tuzilac { get; set; }
        public string Mesto { get; set; }
        public List<UplataModel> Uplate { get; set; }
        public List<PredmetRocisteModel> Rocista { get; set; }

        public PredmetModel() {
            Uplate = new List<UplataModel>();
            Rocista = new List<PredmetRocisteModel>();
        }
    }
}
