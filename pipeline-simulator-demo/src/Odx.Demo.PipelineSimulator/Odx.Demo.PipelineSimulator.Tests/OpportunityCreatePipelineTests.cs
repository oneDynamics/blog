using FakeXrmEasy.Abstractions.Plugins.Enums;
using FakeXrmEasy.Pipeline;
using FakeXrmEasy.Plugins.PluginSteps;
using Microsoft.Xrm.Sdk;
using Odx.Demo.Model;
using Odx.Demo.PipelineSimulator.Plugins;
using System.Linq;
using System;
using Xunit;
using FakeXrmEasy.Plugins;

namespace Odx.Demo.PipelineSimulator.Tests;

public class OpportunityCreatePipelineTests : FakeXrmEasyPipelineTestsBase
{
    [Fact]
    public void Test()
    {
       // _context.ExecutePluginWith<OpportunityRatingPlugin>(); 

        _context.RegisterPluginStep<OpportunityRatingPlugin>(new PluginStepDefinition()
        {
            MessageName = "Create",
            EntityLogicalName = Opportunity.EntityLogicalName,
            Stage = ProcessingStepStage.Preoperation
        });

        _context.RegisterPluginStep<OpportunityNotificationsPlugin>(new PluginStepDefinition()
        {
            MessageName = "Create",
            EntityLogicalName = Opportunity.EntityLogicalName,
            Stage = ProcessingStepStage.Postoperation
        });

        var ownerId = Guid.NewGuid();
        var managerId = Guid.NewGuid();
        var accountId = Guid.NewGuid();

        var manager = new SystemUser()
        {
            Id = managerId
        };

        var owner = new SystemUser()
        {
            Id = ownerId,
            ParentSystemUserId = manager.ToEntityReference()
        };

        var account = new Account()
        {
            Id = accountId,
            Revenue = new Money(20000000),
            OwnerId = owner.ToEntityReference(),         
        };

        _service.Create(manager);
        _service.Create(owner);
        _service.Create(account);

        _service.Create(new Opportunity()
        {
            CustomerId = account.ToEntityReference(),
            OwnerId = owner.ToEntityReference()
        });

        var result = _context.CreateQuery<Email>().FirstOrDefault();

        Assert.Equal(managerId, result?.To?.FirstOrDefault()?.PartyId?.Id);
    }
}