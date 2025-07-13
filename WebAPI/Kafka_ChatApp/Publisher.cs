
using System;
using Confluent.Kafka;

class Publisher
{
    public static async Task Main(string[] args)
    {
        var config = new ProducerConfig { BootstrapServers = "localhost:9092" };

        using var producer = new ProducerBuilder<Null, string>(config).Build();
        while (true)
        {
            Console.Write("Enter message: ");
            var msg = Console.ReadLine();
            await producer.ProduceAsync("chat-topic", new Message<Null, string> { Value = msg });
        }
    }
}
