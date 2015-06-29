using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entity;
using Ninject;
using Observatory.Controllers;
using Moq;
using Observatory.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Observatory.Tests.Controllers
{
    [TestClass]
    public class ObservationControllerTest
    {
        /// <summary>
        /// 
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            //IKernel kernel = new StandardKernel();
            //var samurai = kernel.Get<Samurai>();
        }

        [TestMethod]
        public async Task GetObservationsTest()
        {
            var repository = new Mock<ObservationRepository>(new ObservationContext());
            var observations = new Mock<IEnumerable<Observation>>();
            repository.Setup(repo => repo.Get()).Returns(Task.FromResult(observations.Object));

            var controller = new ObservationController(repository.Object);
            IEnumerable<Observation> result = await controller.Get();

            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(IEnumerable<Observation>));
        }
    }
}
