using System;
using CP380_B1_BlockList.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace CP380_B1_BlockList
{
    class Program
    {
        static void Main(string[] args)
        {



            var startTime = DateTime.Now;
            Console.WriteLine(startTime.ToString());
            var myChain = new BlockList();




            List<Payload> data = new()
            {
                new Payload("Assignment-2-Part-A", TransactionTypes.GRANT, "2C", 1),
                new Payload("CP-380", TransactionTypes.BUY, "2C", 1),
                new Payload("Aditya", TransactionTypes.BUY, "2C", 1)
            };

            var block = new Block(DateTime.Now, null, data);

            myChain.AddBlock(block);
            var endtime = DateTime.Now;
            Console.WriteLine($"Durayion:{endtime-startTime}");

            var json = JsonSerializer.Serialize(myChain.Chain);
            //var json = JsonSerializer.Serialize(myChain.Chain[1].Data);
            Console.WriteLine(PrettyJson.MakePretty(json));

            Console.WriteLine($"Is the chain valid --> {myChain.IsValid()}");

            Console.ReadKey();
        }
    }
}
