using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Api.Database.Entity.Threats;
using Api.Domain.Bots;
using FizzWare.NBuilder;
using Moq;
using Threenine.Data;
using Threenine.Map;
using Xunit;

namespace Swc.Service.Tests
{
    public class ReferrerServiceTests :  IClassFixture<ServiceTestFixture>, IDisposable
    {
        private readonly ServiceTestFixture _serviceFixture;
        public ReferrerServiceTests(ServiceTestFixture fixture)
        {
            _serviceFixture = fixture;
         
        }

        [Fact]
        public void Should_Return_Referrer_Enumerable()
        {
          
            //var uow = Mock < IUnitOfWork<T>();

            //var service = new ReferrerService();

            //var referers = service.GetAllActive();

            //Assert.Equal(10, referers.Count());
            //Assert.IsAssignableFrom<IEnumerable<Referer>>(referers);

        }

        public void Dispose()
        {
            _serviceFixture?.Dispose();
        }
    }
}
