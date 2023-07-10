using Moq;
using Undine.Core;
using Undine.LeopotamEcs.Tests.Components;

namespace Undine.LeopotamEcs.Tests
{
    [TestClass]
    public class LeopotamEcsContainerTests
    {
        [TestInitialize]
        public void Init()
        {
        }

        [TestMethod]
        public void EntityCanBeCreated()
        {
            var container = new LeopotamEcsContainer();
            var entity = container.CreateNewEntity();
            Assert.IsNotNull(entity);
        }

        [TestMethod]
        public void OneTypeSystemCanBeAdded()
        {
            var container = new LeopotamEcsContainer();
            var mock = new Mock<UnifiedSystem<AComponent>>();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void TwoTypeSystemCanBeAdded()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent>>();
            var container = new LeopotamEcsContainer();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void ThreeTypeSystemCanBeAdded()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent>>();
            var container = new LeopotamEcsContainer();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void FourTypeSystemCanBeAdded()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent, DComponent>>();
            var container = new LeopotamEcsContainer();
            container.AddSystem(mock.Object);
        }

        [TestMethod]
        public void OneTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent>>();
            var container = new LeopotamEcsContainer();
            container.GetSystem(mock.Object);
        }

        [TestMethod]
        public void TwoTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent>>();
            var container = new LeopotamEcsContainer();
            container.GetSystem(mock.Object);
        }

        [TestMethod]
        public void ThreeTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent>>();
            var container = new LeopotamEcsContainer();
            container.GetSystem(mock.Object);
        }

        [TestMethod]
        public void FourTypeSystemCanBeRetrieved()
        {
            var mock = new Mock<UnifiedSystem<AComponent, BComponent, CComponent, DComponent>>();
            var container = new LeopotamEcsContainer();
            container.GetSystem(mock.Object);
        }
    }
}