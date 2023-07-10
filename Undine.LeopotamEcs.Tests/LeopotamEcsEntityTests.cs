using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undine.LeopotamEcs.Tests.Components;

namespace Undine.LeopotamEcs.Tests
{
    [TestClass]
    public class LeopotamEcsEntityTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void ComponentCanBeAdded()
        {
            var container = new LeopotamEcsContainer();
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
        }

        [TestMethod]
        public void ComponentCanBeRetrieved()
        {
            var container = new LeopotamEcsContainer();
            //var mock = new Mock<UnifiedSystem<AComponent>>();
            //container.AddSystem(mock.Object);
            container.Init();
            var entity = container.CreateNewEntity();
            entity.AddComponent(new AComponent());
            ref var component = ref entity.GetComponent<AComponent>();
            Assert.IsNotNull(component);
        }//
    }
}