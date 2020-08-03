using MongoDB.Bson;
using MongoDB.Driver;
using MongoProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject
{
      public class DatabaseContext
        {
            private IMongoDatabase MongoDB { get; set; }
            public IMongoCollection<PredmetModel> Predmet { get; set; }
            public IMongoCollection<RocisteModel> Rociste { get; set; }
        public DatabaseContext(DatabaseSettings settings)
            {
                MongoClient client = new MongoClient(settings.ConnectionString);
                MongoDB = client.GetDatabase(settings.DatabaseName);
                bool isActiveServer = MongoDB.RunCommandAsync((Command<BsonDocument>)"{ping:1}")
                                                     .Wait(settings.ServerResponeWaitTime);
             if (!isActiveServer)
                    throw new Exception("Mongo server didnt respond: check if the server is running");

            Predmet = MongoDB.GetCollection<PredmetModel>(settings.PredmetCollectionName);
            Rociste = MongoDB.GetCollection<RocisteModel>(settings.RocisteCollectionName);

        }

        }
    }

