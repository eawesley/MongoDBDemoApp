using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoDBDemo
{
    public class ECRModel
    {
        [BsonId] // _id field
        public Guid Id { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }
        public List<PartChange> Changes { get; set; }
    }
}