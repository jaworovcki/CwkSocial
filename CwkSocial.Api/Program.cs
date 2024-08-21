using CwkSocial.Api.Options;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.AspNetCore.Mvc.Versioning;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterServices(typeof(Program));

// Add services to the container.

var app = builder.Build();

app.RegisterPipelineComponents(typeof(Program));

app.Run();