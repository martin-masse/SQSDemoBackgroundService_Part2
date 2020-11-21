using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nuages.QueueService;

namespace Demo.API
{
    public class TextMessageWorkerService : QueueWorkerService
    {

        public TextMessageWorkerService(IServiceProvider serviceProvider, 
                                        ILogger<QueueWorkerService> logger, 
                                        IConfiguration configuration) : base(serviceProvider, logger)
        {
             QueueName = configuration.GetValue<string>("QueueService:TextMessageQueueName");
        }
        
        protected override async Task<bool> ProcessMessageAsync(QueueMessage msg)
        {
            LogInformation(msg.Body);

            return await Task.FromResult(true);
        }
    }
}