using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Nuages.QueueService;

namespace Demo.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestsController : ControllerBase
    {
        private readonly IQueueService _queueService;
        private readonly IConfiguration _configuration;

        public TestsController(IQueueService queueService, IConfiguration configuration)
        {
            _queueService = queueService;
            _configuration = configuration;
        }
        
        [HttpPost("PublishToQueue")]
        public async Task<ActionResult<bool>> PublishToQueue(string message)
        {
            var queueName = _configuration.GetValue<string>("QueueService:TextMessageQueueName");
            var queueUrl = await _queueService.GetQueueUrlAsync(queueName);
           
            return  await _queueService.PublishToQueueAsync(queueUrl, message);
        }
    }
}