using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using ProjetoMensageria.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
  private readonly IConfiguration _config;
  private readonly string serviceBusConnectionString;

  public ProductController(IConfiguration config)
  {
    _config = config;
    serviceBusConnectionString = _config.GetValue<string>("AzureBusConnectionString");
  }

  [HttpPost]
  [Route("queue")]
  public async Task<IActionResult> SaveAtQueue(Product product)
  {
    await SendMessageToQueue(product);
    return Ok(product);
  }

  [HttpPost]
  [Route("topic")]
  public async Task<IActionResult> SaveAtTopic(Product product)
  {
    await SendMessageToTopic(product);
    return Ok(product);
  }

  private async Task SendMessageToQueue(Product product)
  {
    var queueName = "produto";

    var client = new QueueClient(serviceBusConnectionString, queueName, ReceiveMode.PeekLock);
    string messageBody = JsonSerializer.Serialize(product);
    var message = new Message(Encoding.UTF8.GetBytes(messageBody));

    Console.WriteLine("############## Enviei pra fila ####################");
    await client.SendAsync(message);
    await client.CloseAsync();
  }

  private async Task SendMessageToTopic(Product product)
  {
    var topicName = "produto-topico";

    var client = new TopicClient(serviceBusConnectionString, topicName);
    string messageBody = JsonSerializer.Serialize(product);
    var message = new Message(Encoding.UTF8.GetBytes(messageBody));

    await client.SendAsync(message);
    await client.CloseAsync();
  }
}
