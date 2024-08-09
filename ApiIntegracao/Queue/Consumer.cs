using System.Text;
// using RabbitMQ.Client;
// using RabbitMQ.Client.Events;

namespace ApiIntegracao.Queue
{
    public class Consumer : BackgroundService, IBus{
        // private readonly IConnection _connectionRabbitmq;
        // private readonly IModel _channelRabbitmq;
        public Consumer()
        {
            // var factory = new ConnectionFactory
            // {
            //     HostName = "localhost"
            // };
            // _connectionRabbitmq =  factory.CreateConnection();
            // _channelRabbitmq  = _connectionRabbitmq.CreateModel();
            // _channelRabbitmq.QueueDeclare("create_pedido", false, false, false, null);
        }

        public void BasicConsume()
        {
            // var consumer = new EventingBasicConsumer(_channelRabbitmq);
            // consumer.Received += (sender, eventArgs) => 
            // {                
            //     var contentArray = eventArgs.Body.ToArray();
            //     var contentString = Encoding.UTF8.GetString(contentArray);
            //     Console.WriteLine("Lido " + contentString);
            // };
            // _channelRabbitmq.BasicConsume("create_pedido", false, consumer);
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            BasicConsume();
            return Task.CompletedTask;
        }
    }
}