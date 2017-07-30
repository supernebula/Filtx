﻿using MongoDB.Driver;
using Evol.Common;

namespace Evol.MongoDB.Repository
{
    public class NamedMongoDbContext : INamed
    {
        public string Name { get; set; }

        public IMongoClient MongoClient { get; private set; }

        public IMongoDatabase Database { get; private set; }

        protected NamedMongoDbContext(string connectionString)
        {
            Name = connectionString;
            var mongoUrl = new MongoUrl(connectionString);
            MongoClient = new MongoClient(mongoUrl);
            Database = MongoClient.GetDatabase(mongoUrl.DatabaseName);
        }

        protected NamedMongoDbContext(MongoDbContextOptions options)
        {
            Name = options.DbContextType.FullName;
            var mongoUrl = new MongoUrl(options.ConnectionString);
            MongoClient = new MongoClient(mongoUrl);
            Database = MongoClient.GetDatabase(mongoUrl.DatabaseName);
        }
    }
}
