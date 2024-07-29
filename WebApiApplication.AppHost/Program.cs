var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.WebApiApplication>("webapiapplication");

builder.Build().Run();
