# SQSDemoBackgroundService_Part2

Support code for the following article

https://medium.com/@martinmasse/build-an-aws-sqs-background-service-with-net-5-part-2-c8a571c11b6a

# Prerequisites

You will need this to run the code.

- AWS Account
- An IAM user with SQS access rights
- .NET 5 (or 3.1, you will have to change the target framework)

# How to run the demo
- Clone this repository
- Set TaskWorkerService:QueueName to the name of your queue in appsettings.json
- Set AWS:Profile (or make sure you have a Default profile setup in .aws) and AWS:Region in appsettings.json 
- cd Demo.API
- dotnet watch run
- To to https://localhost:5001/swagger/index.html
