using Infra.Data.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;

namespace Infra.Data.DbContext
{
    public class MongoDbContext : IDbContext
    {
        IMongoClient client;
        public IMongoDatabase database;

        public MongoDbContext(IConfiguration configuration)
        {
            client = new MongoClient(GetConnectionString(configuration));
            database = client.GetDatabase(GetDatabaseName(configuration));
        }

        public IMongoCollection<TDocument> DbSet<TDocument>()
        {
            return database.GetCollection<TDocument>(typeof(TDocument).Name);
        }

        private string GetConnectionString(IConfiguration configuration)
        {
            return Environment.GetEnvironmentVariable("MONGOCONNECTION") ?? configuration.GetSection("MongoSettings").GetSection("Connection").Value;
        }

        private string GetDatabaseName(IConfiguration configuration)
        {
            return Environment.GetEnvironmentVariable("DATABASENAME") ?? configuration.GetSection("MongoSettings").GetSection("DatabaseName").Value;
        }
    }
}

