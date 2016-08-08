using System;
using System.Text;
using System.Collections.Generic;
using Domum.Data.Domain;
using Domum.Data.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Domum.Data.Tests
{
    /// <summary>
    /// Summary description for ConfigurationRepositoryTests
    /// </summary>
    [TestClass]
    public class ConfigurationRepositoryTests
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void UT_Configuration_GetById()
        {
            var configurationRepository = new ConfigurationRepository();
            var config = configurationRepository.GetConfigurationById(1);

            Assert.IsNotNull(config);

        }

        [TestMethod]
        public void UT_Configuration_Create()
        {
            var newConfiguration = new Configuration()
            {
                ConfigId = 2,
                ConfigKey = "TEST",
                ConfigValue = "Ruben"
            };

            var configurationRepository = new ConfigurationRepository();
            configurationRepository.SaveOrUpdate(newConfiguration);
        }
    }
}
