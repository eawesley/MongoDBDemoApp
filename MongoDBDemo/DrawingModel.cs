using System;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDemo
{
    public class DrawingModel
    {
        [BsonId] // _id field
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Revision { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }
}