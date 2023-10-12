using FakeXrmEasy.Abstractions;
using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Middleware;
using FakeXrmEasy.Middleware.Crud;
using FakeXrmEasy.Middleware.Messages;
using FakeXrmEasy.Middleware.Pipeline;
using Microsoft.Xrm.Sdk;

namespace Odx.Demo.PipelineSimulator.Tests;

public class FakeXrmEasyPipelineTestsBase
{
    protected readonly IXrmFakedContext _context;
    protected readonly IOrganizationService _service;

    public FakeXrmEasyPipelineTestsBase()
    {
        _context = MiddlewareBuilder
                        .New()
                        .AddCrud()
                        .AddFakeMessageExecutors()
                        .AddPipelineSimulation()
                        .UsePipelineSimulation()
                        .UseCrud()
                        .UseMessages()
                        .SetLicense(FakeXrmEasyLicense.RPL_1_5)
                        .Build();

        _service = _context.GetAsyncOrganizationService();
    }
}