﻿using EventManagementSystem.Data;
using NUnit.Framework;

namespace IntegrationTesting
{
  public abstract class IntegrationTestBase
  {
    protected ApplicationDbContext _dbContext = null!;

    [SetUp]
    public void SetUp()
    {
      var dbContextFactory = new ApplicationDbContextFactory();
      _dbContext = dbContextFactory.CreateDbContext(new string[] { });
    }

    [TearDown]
    public void TearDown()
    {
      if (_dbContext != null)
      {
        _dbContext.Dispose();
      }
    }
  }
}
