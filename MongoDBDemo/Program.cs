using System;

namespace MongoDBDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoCRUD db = new MongoCRUD("InfluxECR");
            
            Console.ReadLine();
        }
    }
}
