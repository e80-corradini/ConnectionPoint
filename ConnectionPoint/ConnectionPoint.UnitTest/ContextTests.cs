using AutoMapper;
using ConnectionPoint.Controllers;
using ConnectionPoint.Domain;
using ConnectionPoint.Shared;
using ConnectionPoint.Shared.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace ConnectionPoint.UnitTest
{

    [TestClass]
    public class ContextTests
    {
        DbContextOptions<ConnectionPointContext> options;
        IMapper mapper;

        public ContextTests()
        {
            //create In Memory Database
            options = new DbContextOptionsBuilder<ConnectionPointContext>()
            .UseInMemoryDatabase(databaseName: "ConnectionPointMockedContext")
            .Options;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });

            mapper = new Mapper(config);
        }
        
        [TestMethod]
        public void TestContextCreation()
        {
            var context = new ConnectionPointContext(options);
            Assert.IsNotNull(context);
        }

        [TestMethod]
        public void TestMapperConfiguration()
        {
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }

        [TestMethod]
        public void TestCustomerCRUD()
        {
            CustomerDTO customer = new CustomerDTO()
            {
                Name = "UNITTEST",
                Description="UNITTEST",
                InsertDateTime = System.DateTime.Now,
                LastUpdateUser="TestMethod",
                LastUpdateDateTime = System.DateTime.Now
            };

            var controller = new CustomerController(new ConnectionPointContext(options), mapper);

            //Create
            controller.Post(customer).Wait();
            Assert.IsTrue(controller.ModelState.IsValid);

            //read
            var items = controller.Index();
            var cust = ((items as ViewResult).Model as IEnumerable<CustomerDTO>).FirstOrDefault(); 
            Assert.IsNotNull(cust);




        }
    }
}
