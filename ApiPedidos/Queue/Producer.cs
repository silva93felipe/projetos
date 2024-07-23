

using System.Text;
using ApiPedidos.Contratos;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace ApiPedidos.Queue
{
    public class Producer : IBus{

        public void Publish<T>(T message)
        {
            var factory = new ConnectionFactory() { 
                HostName = "localhost", 
                // Port = 5672,
                // UserName="guest", 
                // Password="guest" 
            };
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();
            channel.QueueDeclare(queue: "create_pedido",
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);
            var json = JsonConvert.SerializeObject(message);
            var body = Encoding.UTF8.GetBytes(json);
            channel.BasicPublish("", "create_pedido", null, body);
        }
    }
}