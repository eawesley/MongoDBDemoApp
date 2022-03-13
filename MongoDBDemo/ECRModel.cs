using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDemo
{
    public class ECRModel
    {
        [BsonId] // _id field
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public PartChange Change { get; set; }
    }
}