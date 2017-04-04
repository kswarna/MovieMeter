using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProjectManhattan.Repository.Tests
{
    [TestClass]
    public class TestProjectInitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            MapperConfig.InitializeMapper();
        }
    }
}
