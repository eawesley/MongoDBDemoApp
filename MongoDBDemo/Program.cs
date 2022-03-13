using System;
using System.Collections.Generic;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("InfluxECR");

            ECRModel exampleChange = new ECRModel
            {
                Number = "1045",
                Description = "An example change",
                Changes = new List<PartChange>
                {
                    new PartChange()
                    {
                        Part = new DrawingModel()
                        {
                            Number = "M1456"
                        },
                        Description = "An example part change"
                    }
                }
            };
            
            Console.ReadLine();
        }
    }
}
