using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoProject
{
	public class DatabaseSettings
	{
		//General Settings
		public string ConnectionString { get; set; }
		public string DatabaseName { get; set; }
		public int ServerResponeWaitTime { get; set; }

		//Collecion Names
		public string PredmetCollectionName { get; set; }
		public string RocisteCollectionName { get; set; }

	}
}
