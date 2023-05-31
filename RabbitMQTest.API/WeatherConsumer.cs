using MassTransit;
using Newtonsoft.Json;
using System.Diagnostics;

namespace RabbitMQTest.API
{
    public class WeatherConsumer : IConsumer<WeatherForecast>
    {
        public async Task Consume(ConsumeContext<WeatherForecast> context)
        {
            var jsonMessage = JsonConvert.SerializeObject(context.Message);
            Debug.WriteLine($"Weather message: {jsonMessage}");
        }
    }
}
