using Microsoft.Extensions.Configuration;
using static System.Reflection.Metadata.BlobBuilder;

var builder = DistributedApplication.CreateBuilder(args);

var blobs = builder.AddConnectionString("blobs");

var apiService = builder.AddProject<Projects.AspireBlob_ApiService>("apiservice")
    .WithReference(blobs);


builder.AddProject<Projects.AspireBlob_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);


builder.Build().Run();
