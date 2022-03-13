using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDemo
{
    public class PartChange
    {
        [BsonId] // _id field
        public Guid Id { get; set; }
        public DrawingModel Part { get; set; }
        public string Description { get; set; }
    }
}